using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class ListOfJobs and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class ListOfJobs : MyFormPage
    {
        private JobController jobCtr;
        private string role;
        //Used for PrintPage for values that must not be reset
        private int iRow = 0;
        private bool nPage = true;
        private bool fPage = true;
        private StringFormat strFormat = new StringFormat();
        private List<int> arrColumnLefts = new List<int>();
        private List<int> arrColumnWidths = new List<int>();
        private int cellHeight = 0;

        /// <summary>
        /// this is the constructor for the class ListOfJobs.
        /// </summary>
        public ListOfJobs(string role)
        {
            InitializeComponent();
            panel = listOfJobs_panel;
            jobCtr = JobController.GetInstance();
            jobCtr.CheckRoutines();
            this.role = role;
            ResetBoxes();

        }

        /// <summary>
        /// This method resets the boxes in the class ListOfJobs.
        /// </summary>
        private void ResetBoxes()
        {
            dateStart_dateTimePicker.Value = DateTime.Today;
            dateEnd_dateTimePicker.Value = DateTime.Today;
            cbSubGroup.SelectedItem = null;
            cbSubGroup.DataSource = jobCtr.GetAllSubGroups();
            cbSubGroup.DisplayMember = "Name";

            chbStartDate.Checked = true;
            chbEndDate.Checked = true;
            chbSubGroup.Checked = false;

            DynamicSearch();
        }

        /// <summary>
        /// This method adds the list of jobs to the list jobs_ListView.
        /// </summary>
        /// <param name="jobs"></param>
        private void AddJobsToList(List<Job> jobs)
        {
            jobs = jobs.OrderBy(j => j.date).ToList();
            jobListGridView.DataSource = jobs;

            jobListGridView.Columns[0].HeaderText = @"Title";
            jobListGridView.Columns[1].HeaderText = @"Description";
            jobListGridView.Columns[2].HeaderText = @"Role";
            //jobListGridView.Columns[2].Visible = false;
            jobListGridView.Columns[3].HeaderText = @"Frequency";
            jobListGridView.Columns[4].HeaderText = @"Date";
            jobListGridView.Columns[5].Visible = false;
            jobListGridView.Columns[6].Visible = false;
            jobListGridView.Columns[7].Visible = false;
            jobListGridView.Columns[8].HeaderText = @"Is it done?";
            jobListGridView.Columns[9].Visible = false;
            jobListGridView.Columns[10].Visible = false;
            jobListGridView.Columns[11].Visible = false;
            //jobListGridView.Columns[12].Visible = false;
            jobListGridView.Columns[12].HeaderText = @"Sub Group";
            jobListGridView.Columns[13].HeaderText = @"Name of Employee";
            jobListGridView.Columns[13].Visible = false;
            jobListGridView.Columns[13].DisplayIndex = 3;
            jobListGridView.Columns[14].Visible = false;
            jobListGridView.Columns[15].Visible = false;
            jobListGridView.Columns[16].Visible = false;
            jobListGridView.Columns[17].Visible = false;
            jobListGridView.Columns[18].Visible = false;
        }

        /// <summary>
        /// This method find jobs by search criteria.
        /// </summary>
        public void DynamicSearch()
        {
            List<Job> jobs = jobCtr.DynamicSearch(chbStartDate.Checked, chbEndDate.Checked, chbSubGroup.Checked, dateStart_dateTimePicker.Value.Date, dateEnd_dateTimePicker.Value.Date, role, cbSubGroup.Text);
            AddJobsToList(jobs);
        }

        /// <summary>
        /// This method colors the rows with delayed jobs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void jobListGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in jobListGridView.Rows)
            {
                Job job = row.DataBoundItem as Job;

                if (job != null)
                {
                    if (job.date < DateTime.Today.Date && job.done == false)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// This method call the DynamicSearch method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DynamicSearch();
        }

        /// <summary>
        /// This method call the ResetBoxes method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBoxes();
        }

        /// <summary>
        /// This method opens the windows form UpdateJob.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            UpdateJob();
        }

        /// <summary>
        /// This method opens the windows form updateJob.
        /// </summary>
        private void UpdateJob()
        {
            Job jobToUpdate = jobListGridView.SelectedRows[0].DataBoundItem as Job;
            Form updateJob = new UpdateJob(jobToUpdate, this, role);
            updateJob.ShowDialog();
        }

        /// <summary>
        /// This method opens the windows form CreateJob.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            CreateJob cj = new CreateJob(this, role);
            cj.ShowDialog();
        }

        /// <summary>
        /// This method prints a list of jobs out on a printer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method makes a preview of what would be printed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method prints the data grid view out on a printer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            foreach (DataGridViewColumn dgvGridCol in jobListGridView.Columns)
            {
                if (jobListGridView.Columns[count].Visible == true)
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
                foreach (DataGridViewColumn GridCol in jobListGridView.Columns)
                {
                    if (jobListGridView.Columns[count].Visible == true)
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
            while (iRow <= jobListGridView.RowCount - 1 && bMorePagesToPrint == false)
            {
                DataGridViewRow GridRow = jobListGridView.Rows[iRow];

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

                        e.Graphics.DrawString("Job Summary",
                            new Font(jobListGridView.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left,
                            e.MarginBounds.Top - e.Graphics.MeasureString("Job Summary",
                            new Font(jobListGridView.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToLongDateString() + " " +
                            DateTime.Now.ToShortTimeString();

                        //Draw Date
                        e.Graphics.DrawString(strDate,
                            new Font(jobListGridView.Font, FontStyle.Bold), Brushes.Black,
                            e.MarginBounds.Left +
                            (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                            new Font(jobListGridView.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Width),
                            e.MarginBounds.Top - e.Graphics.MeasureString("Job Summary",
                            new Font(new Font(jobListGridView.Font, FontStyle.Bold),
                            FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        topMargin = e.MarginBounds.Top;
                        check = 0;
                        foreach (DataGridViewColumn GridCol in jobListGridView.Columns)
                        {
                            if (jobListGridView.Columns[count].Visible == true)
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
                        if (jobListGridView.Columns[count].Visible == true)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.Style.Font = new Font("Arial", 7),
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[check],
                                    (float)topMargin,
                                    (int)arrColumnWidths[check], (float)cellHeight),
                                    strFormat);
                                Cel.Style.Font = new Font("Microsoft Sans Serif", 8.25F);
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

        /// <summary>
        /// This method calls the method UpdateEmployee when there is double clicked on a cell in the data grid view dgvEmployees.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jobListGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateJob();
        }
    }
}