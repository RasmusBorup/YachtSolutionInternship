using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class LogBook and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class LogBook : MyFormPage
    {
        private LogBookController logbookCtr;
        //Used for PrintPage for values that must not be reset
        private int iRow = 0;
        private bool nPage = true;
        private bool fPage = true;
        private StringFormat strFormat = new StringFormat();
        private List<int> arrColumnLefts = new List<int>();
        private List<int> arrColumnWidths = new List<int>();
        private int cellHeight = 0;

        /// <summary>
        /// This is the constructor for the class LogBook.
        /// </summary>
        public LogBook()
        {
            InitializeComponent();
            logbookCtr = LogBookController.GetInstance();
            panel = pnlLogBook;

            if (logbookCtr.FindLogBook(DateTime.Today) == null)
            {
                logbookCtr.CreateLogBook(DateTime.Today, "", "", "");
            }
            CheckForMissingLogBooks();

            try
            {
                dtpLogBookDate.MinDate = logbookCtr.GetAllLogBooks().OrderBy(l => l.date).First().date;
                dtpLogBookDate.MaxDate = logbookCtr.GetAllLogBooks().OrderBy(l => l.date).Last().date;
                dtpLogBookDate.Value = DateTime.Today;
                rtbDescription.Text = logbookCtr.FindLogBook(DateTime.Today).description;
                rtbRemarks.Text = logbookCtr.FindLogBook(dtpLogBookDate.Value.Date).remarks;
                cbChief.Text = logbookCtr.FindLogBook(dtpLogBookDate.Value.Date).chiefEngineer;
            }
            catch (Exception)
            {
                
            }

            Text = "Log Book";
            ShowDGVReadings();
        }

        private void CheckForMissingLogBooks()
        {
            if (logbookCtr.GetAllLogBooks().Count > 1)
            {
                bool notDone = true;
                int i = 1;
                while (notDone && i < 365)
                {
                    if (logbookCtr.FindLogBook(DateTime.Today.AddDays(-i)) == null)
                    {
                        logbookCtr.CreateLogBook(DateTime.Today.AddDays(-i), "", "", "");
                    }
                    else
                    {
                        notDone = false;
                    }
                    i++;
                }
            }
        }

        /// <summary>
        /// This method creates the columns in the data grid view readings.
        /// </summary>
        public void ShowDGVReadings()
        {
            DataTable readings = new DataTable();
            readings.Columns.Add("Item", typeof(string));
            readings.Columns.Add("Unit", typeof(string));
            readings.Columns.Add("Today", typeof(double));
            readings.Columns.Add("Yesterday", typeof(double));

            List<LogItemReading> readingsList = logbookCtr.GetAllLogItemReadings().Where(r => r.date == dtpLogBookDate.Value.Date).ToList();

            foreach (LogItemReading reading in readingsList)
            {
                Object[] o = { reading.logItem, reading.LogItem1.unitOfMeasurement, reading.todaysReading, reading.yesterdaysReading };
                readings.Rows.Add(o);
            }

            dgvLogItems.DataSource = readings;
            dgvLogItems.Columns[0].ReadOnly = true;
            dgvLogItems.Columns[0].FillWeight = 45;
            dgvLogItems.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; 
            dgvLogItems.Columns[1].ReadOnly = true;
            dgvLogItems.Columns[1].FillWeight = 15;
            dgvLogItems.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            if (dtpLogBookDate.Value.Date < DateTime.Today.AddDays(-7))
            {
                dgvLogItems.Columns[2].ReadOnly = true;
            }
            dgvLogItems.Columns[2].FillWeight = 15;
            dgvLogItems.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
            dgvLogItems.Columns[3].ReadOnly = true;
            dgvLogItems.Columns[3].FillWeight = 20;
            dgvLogItems.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
        }

        /// <summary>
        /// This method updates the log item reading and the logbook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool success = true;

            foreach (DataGridViewRow row in dgvLogItems.Rows)
            {
                try
                {
                    success = logbookCtr.UpdateLogItemReading(row.Cells[0].Value.ToString(), dtpLogBookDate.Value.Date, row.Cells[2].Value.ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong when trying to update the hour counts. Error: " + exception);
                }
            }

            try
            {
                success = logbookCtr.UpdateLogBook(dtpLogBookDate.Value.Date, rtbDescription.Text, rtbRemarks.Text, cbChief.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong when trying to update. Error: " + ex);
            }

            if (success)
            {
                ShowDGVReadings();
                MessageBox.Show("The changes were successfully saved in the database");
            }
            CheckForMaintenance();
        }

        /// <summary>
        /// This method check if some of the parts needs an inspection.
        /// </summary>
        private void CheckForMaintenance()
        {
            logbookCtr.CheckMaintenance();
        }

        /// <summary>
        /// This method opens the windows form CreateLogItem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegisterLogItem_Click(object sender, EventArgs e)
        {
            CreateLogItem cli = new CreateLogItem(this);
            cli.ShowDialog();
        }

        /// <summary>
        /// This method opens the windows form UpdateLogItem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetails_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }

        /// <summary>
        /// This method shows the details of a logbook.
        /// </summary>
        private void ShowDetails()
        {
            try
            {
                if (dgvLogItems.RowCount > 0 || dgvLogItems.SelectedRows[0] != null)
                {
                    LogItemReading readingToUpdate =
                        dgvLogItems.SelectedCells[0].OwningRow.DataBoundItem as LogItemReading;
                    readingToUpdate =
                        logbookCtr.FindLogItemReading(dgvLogItems.SelectedCells[0].OwningRow.Cells[0].Value.ToString(),
                    dtpLogBookDate.Value.Date);
                    LogItem logToUpdate = logbookCtr.FindLogItem(readingToUpdate.logItem);
                UpdateLogItem update = new UpdateLogItem(this, logToUpdate, dtpLogBookDate.Value.Date);
                update.ShowDialog();
            }
                else
                {
                    MessageBox.Show("Details can not be shown when nothing is selected");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
        }

        /// <summary>
        /// This method deletes a log item reading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLogItems.RowCount != 0)
            {
                LogItemReading reading =
                    logbookCtr.FindLogItemReading((dgvLogItems.SelectedCells[0].OwningRow.Cells[0].Value.ToString()),
                        dtpLogBookDate.Value.Date);
                DialogResult answer = MessageBox.Show("Are you sure you want to delete the log item?", "Warning", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    if (logbookCtr.DeleteLogItem(reading.logItem))
                    {
                        ShowDGVReadings();
                        MessageBox.Show("The item was deleted.");
                    }
                    else
                    {
                        MessageBox.Show("There was a problem with deleting this log item");
                    }
                }
            }
        }

        /// <summary>
        /// This method sets the DateTimePicker dtpLogBookDate one day back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreviousDate_Click(object sender, EventArgs e)
        {
            if (dtpLogBookDate.MinDate == dtpLogBookDate.MaxDate)
            {
                dtpLogBookDate.MinDate = logbookCtr.GetAllLogBooks().OrderBy(l => l.date).First().date;
            }
            if (dtpLogBookDate.Value.AddDays(-1) >= dtpLogBookDate.MinDate)
            {
                dtpLogBookDate.Value = dtpLogBookDate.Value.AddDays(-1);
            }
            else
            {
                MessageBox.Show("There is no logbook for this date yet");
            }
        }

        /// <summary>
        /// This method sets the DateTimePicker dtpLogBookDate one day forward.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextDate_Click(object sender, EventArgs e)
        {
            if (dtpLogBookDate.Value.AddDays(1) <= dtpLogBookDate.MaxDate)
            {
                dtpLogBookDate.Value = dtpLogBookDate.Value.AddDays(1);
            }
            else
            {
                MessageBox.Show("There is no logbook for this date yet");
            }
        }

        /// <summary>
        /// This method finds a logbook by its date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (logbookCtr.FindLogBook(dtpLogBookDate.Value.Date) != null)
            {
                ShowDGVReadings();
                rtbDescription.Text = logbookCtr.FindLogBook(dtpLogBookDate.Value.Date).description;
                rtbRemarks.Text = logbookCtr.FindLogBook(dtpLogBookDate.Value.Date).remarks;
                cbChief.Text = logbookCtr.FindLogBook(dtpLogBookDate.Value.Date).chiefEngineer;
            }
            else
            {
                dtpLogBookDate.Value = DateTime.Today;
                MessageBox.Show("There is no logbook for this date");
            }
        }

        /// <summary>
        /// This method ???.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLogItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += dataGridViewTextBox_KeyPress;
            e.Control.KeyPress += dataGridViewTextBox_KeyPress;
        }

        /// <summary>
        /// This method checks on key press whether or not the input for dgvLogItems contains letters or more than one comma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(dgvLogItems.SelectedCells[0].Value.ToString(), @","))
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 08 || e.KeyChar == 44)
                {
                    return;
                }
            }
            else
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 08)
                {
                    return;
                }
            }

            e.Handled = true;
        }

        /// <summary>
        /// This method checks if the current cell contains changes that aren't saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLogItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvLogItems.IsCurrentCellDirty)
            {
                dgvLogItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvLogItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetails();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            iRow = 0;
            fPage = true;
            nPage = true;

            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            iRow = 0;
            fPage = true;
            nPage = true;

            //Open the print preview dialog
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument1;
            objPPdialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool bMorePagesToPrint = false;

            strFormat.Alignment = StringAlignment.Near;
            strFormat.LineAlignment = StringAlignment.Center;
            strFormat.Trimming = StringTrimming.EllipsisCharacter;

            int count = 0;
            int check = 0;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int tmpWidth = 0;
            int totalWidth = 0;
            int headerHeight = 0;

            foreach (DataGridViewColumn dgvGridCol in dgvLogItems.Columns)
            {
                if (dgvLogItems.Columns[count].Visible == true)
                {
                    totalWidth += dgvGridCol.Width;
                }
                count++;
            }
            count = 0;
            ///////////////////////////////////////////////////////////////////////////////

            //For the first page to print set the cell width and header height
            if (fPage)
            {
                foreach (DataGridViewColumn GridCol in dgvLogItems.Columns)
                {
                    if (dgvLogItems.Columns[count].Visible == true)
                    {
                        tmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                        (double)totalWidth * (double)totalWidth *
                        ((double)e.MarginBounds.Width / (double)totalWidth))));

                        headerHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, tmpWidth).Height) + 11;

                        // Save width and height of headers
                        arrColumnLefts.Add(leftMargin);
                        arrColumnWidths.Add(tmpWidth);
                        leftMargin += tmpWidth;
                    }
                    count++;
                }
                count = 0;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////
            while (iRow <= dgvLogItems.RowCount - 1 && bMorePagesToPrint == false)
            {
                DataGridViewRow GridRow = dgvLogItems.Rows[iRow];

                //Set the cell height
                cellHeight = GridRow.Height + 5;

                count = 0;
                if (topMargin + cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    nPage = true;
                    fPage = false;
                    bMorePagesToPrint = true;
                }
                else
                {
                    if (nPage)
                    {
                        //Draw Header

                        e.Graphics.DrawString("Log book Summary",
                            new Font(dgvLogItems.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left,
                            e.MarginBounds.Top - e.Graphics.MeasureString("Log book Summary",
                            new Font(dgvLogItems.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToLongDateString() + " " +
                            DateTime.Now.ToShortTimeString();

                        //Draw Date
                        e.Graphics.DrawString(strDate,
                            new Font(dgvLogItems.Font, FontStyle.Bold), Brushes.Black,
                            e.MarginBounds.Left +
                            (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                            new Font(dgvLogItems.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Width),
                            e.MarginBounds.Top - e.Graphics.MeasureString("Job Summary",
                            new Font(new Font(dgvLogItems.Font, FontStyle.Bold),
                            FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        topMargin = e.MarginBounds.Top;
                        check = 0;
                        foreach (DataGridViewColumn GridCol in dgvLogItems.Columns)
                        {
                            if (dgvLogItems.Columns[count].Visible == true)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)arrColumnLefts[check], topMargin,
                                (int)arrColumnWidths[check], headerHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[check], topMargin,
                                    (int)arrColumnWidths[check], headerHeight));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[check], topMargin,
                                    (int)arrColumnWidths[check], headerHeight), strFormat);
                                check++;
                            }
                            count++;
                        }
                        nPage = false;
                        topMargin += headerHeight;
                    }
                    count = 0;
                    check = 0;
                    //Draw Columns Contents                
                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {
                        if (dgvLogItems.Columns[count].Visible == true)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.Style.Font = new Font("Arial", 8F),
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[check],
                                    (float)topMargin,
                                    (int)arrColumnWidths[check], (float)cellHeight),
                                    strFormat);
                                Cel.Style.Font = new Font("Microsoft Sans Serif", 11.25F);
                            }

                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[check], topMargin,
                                (int)arrColumnWidths[check], cellHeight));
                            check++;
                        }
                        count++;
                    }
                }
                iRow++;
                topMargin += cellHeight;
            }
            if (bMorePagesToPrint)
            {
                e.HasMorePages = true;
                fPage = true;
                nPage = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
    }
}
