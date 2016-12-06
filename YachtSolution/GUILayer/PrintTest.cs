using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class PrintTest and is a subclass to the class Form.
    /// </summary>
    public partial class PrintTest : Form
    {
        private JobController jobCtr;
        private InventoryController inventoryCtr;

        //Used for PrintPage for values that must not be reset
        private int iRow = 0;
        private bool nPage = true;
        private bool fPage = true;
        private StringFormat strFormat = new StringFormat();
        private List<int> arrColumnLefts = new List<int>();
        private List<int> arrColumnWidths = new List<int>();
        private int cellHeight = 0;

        /// <summary>
        /// This is the constructor for the class PrintTest.
        /// </summary>
        public PrintTest()
        {
            InitializeComponent();
            this.jobCtr = JobController.GetInstance();
            this.inventoryCtr = InventoryController.GetInstance();
            
            /***************************************************************************/

            dgvPrint.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrint.DataSource = jobCtr.ListAllJobs();
            //dgvPrint.DataSource = jobCtr.GetAllSubGroups();
            //dgvPrint.DataSource = inventoryCtr.GetAllInventories();

            /***************************************************************************/
            
            dgvPrint.Columns[0].HeaderText = @"Title";
            dgvPrint.Columns[1].HeaderText = @"Description";
            dgvPrint.Columns[2].HeaderText = @"Role";
            //dgvPrint.Columns[2].Visible = false;
            dgvPrint.Columns[3].HeaderText = @"Frequency";
            dgvPrint.Columns[4].HeaderText = @"Date";
            dgvPrint.Columns[5].Visible = false;
            dgvPrint.Columns[6].Visible = false;
            dgvPrint.Columns[7].Visible = false;
            dgvPrint.Columns[8].HeaderText = @"Is it done?";
            dgvPrint.Columns[9].Visible = false;
            dgvPrint.Columns[10].Visible = false;
            dgvPrint.Columns[11].Visible = false;
            //dgvPrint.Columns[12].Visible = false;
            dgvPrint.Columns[12].HeaderText = @"Sub Group";
            dgvPrint.Columns[13].HeaderText = @"Name of Employee";
            dgvPrint.Columns[13].Visible = false;
            dgvPrint.Columns[13].DisplayIndex = 3;
            dgvPrint.Columns[14].Visible = false;
            dgvPrint.Columns[15].Visible = false;
            dgvPrint.Columns[16].Visible = false;
            dgvPrint.Columns[17].Visible = false;
            dgvPrint.Columns[18].Visible = false;

            /****************************************************************************/
            /*
            dgvPrint.Columns[0].HeaderText = @"Name";
            dgvPrint.Columns[1].HeaderText = @"Amount";
            dgvPrint.Columns[2].HeaderText = @"Note";
            dgvPrint.Columns[3].HeaderText = @"Price";
            dgvPrint.Columns[4].HeaderText = @"Minimum Amount";
            dgvPrint.Columns[5].HeaderText = @"Location";
            dgvPrint.Columns[6].HeaderText = @"Manufacturer";
            dgvPrint.Columns[7].HeaderText = @"Serial No.";
            dgvPrint.Columns[8].Visible = false;
            dgvPrint.Columns[9].HeaderText = @"Used For";
            dgvPrint.Columns[10].HeaderText = @"Suppliers";
            dgvPrint.Columns[11].Visible = false;

            /*****************************************************************************/
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
        /// This method shows a preview of the document.
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
        /// This is where the pages are made before they get printed.
        /// </summary>
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

            foreach (DataGridViewColumn dgvGridCol in dgvPrint.Columns)
            {
                if(dgvPrint.Columns[count].Visible == true)
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
                foreach (DataGridViewColumn GridCol in dgvPrint.Columns)
                {
                    if(dgvPrint.Columns[count].Visible == true)
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

            while (iRow <= dgvPrint.RowCount - 1 && bMorePagesToPrint == false)
            {
                Console.WriteLine(iRow);
                Console.WriteLine(dgvPrint.RowCount - 1);
                DataGridViewRow GridRow = dgvPrint.Rows[iRow];

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
                    if(nPage)
                    {
                        //Draw Header

                        e.Graphics.DrawString("Customer Summary",
                            new Font(dgvPrint.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left,
                            e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
                            new Font(dgvPrint.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToLongDateString() + " " +
                            DateTime.Now.ToShortTimeString();

                        //Draw Date
                        e.Graphics.DrawString(strDate,
                            new Font(dgvPrint.Font, FontStyle.Bold), Brushes.Black,
                            e.MarginBounds.Left +
                            (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                            new Font(dgvPrint.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Width),
                            e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
                            new Font(new Font(dgvPrint.Font, FontStyle.Bold),
                            FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        topMargin = e.MarginBounds.Top;
                        check = 0;
                        foreach (DataGridViewColumn GridCol in dgvPrint.Columns)
                        {
                            if(dgvPrint.Columns[count].Visible == true)
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
                            Console.WriteLine("did it");
                        }
                        nPage = false;
                        topMargin += headerHeight;
                    }
                    count = 0;
                    check = 0;
                    //Draw Columns Contents                
                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {
                        if(dgvPrint.Columns[count].Visible == true)
                        {
                        if (Cel.Value != null)
                        {
                            e.Graphics.DrawString(Cel.Value.ToString(),
                                Cel.InheritedStyle.Font,
                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[check],
                                (float)topMargin,
                                    (int)arrColumnWidths[check], (float)cellHeight),
                                strFormat);
                        }

                        //Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[check], topMargin,
                                (int)arrColumnWidths[check], cellHeight));
                            check++;
                        }
                        count++;
                        Console.WriteLine("Did it too");
                    }
                }
                iRow++;
                topMargin += cellHeight;
            }

            if (bMorePagesToPrint)
            {
                e.HasMorePages = true;
                Console.WriteLine("Hello");
                fPage = true;
                nPage = true;
            }

            else
            {
                Console.WriteLine("Goodbye");
                e.HasMorePages = false;
            }
        }
    }
}