using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;
using YachtSolution.ModelLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class InventoryManagement and is a subclass to the class Form.
    /// </summary>
    public partial class InventoryManagement : MyFormPage
    {
        private InventoryController inventoryCtr;
        private List<InventoryItem> inventories;
        //Used for PrintPage for values that must not be reset
        private int iRow = 0;
        private bool nPage = true;
        private bool fPage = true;
        private StringFormat strFormat = new StringFormat();
        private List<int> arrColumnLefts = new List<int>();
        private List<int> arrColumnWidths = new List<int>();
        private int cellHeight = 0;
        private string role;

        /// <summary>
        /// This is the constructor for the class InventoryManagement.
        /// </summary>
        public InventoryManagement(string role)
        {
            InitializeComponent();
            this.panel = PanelMasterPanel;

            inventoryCtr = InventoryController.GetInstance();
            inventories = inventoryCtr.GetAllInventories();
            this.role = role;

            dgvDataAllItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDataAllItems.DataSource = inventories;//inventoryCtr.GetInventoriesByRole(role);
            dgvDataAllItems.Columns[0].HeaderText = @"Name";
            dgvDataAllItems.Columns[1].HeaderText = @"Amount";
            dgvDataAllItems.Columns[2].HeaderText = @"Description";
            dgvDataAllItems.Columns[3].HeaderText = @"Price";
            dgvDataAllItems.Columns[4].HeaderText = @"Minimum Amount";
            dgvDataAllItems.Columns[5].HeaderText = @"Location";
            dgvDataAllItems.Columns[6].HeaderText = @"Manufacturer";
            dgvDataAllItems.Columns[7].HeaderText = @"Serial No.";
            dgvDataAllItems.Columns[8].HeaderText = @"Used For";
            dgvDataAllItems.Columns[9].HeaderText = @"Suppliers";
            dgvDataAllItems.Columns[10].Visible = false;

            dgvDataAllItems.Columns[0].FillWeight = 17;
            dgvDataAllItems.Columns[1].FillWeight = 11;
            dgvDataAllItems.Columns[2].FillWeight = 15;
            dgvDataAllItems.Columns[3].FillWeight = 12;
            dgvDataAllItems.Columns[4].FillWeight = 10;
            dgvDataAllItems.Columns[5].FillWeight = 15;
            dgvDataAllItems.Columns[6].FillWeight = 16;
            dgvDataAllItems.Columns[7].FillWeight = 13;
            dgvDataAllItems.Columns[8].FillWeight = 13;
            dgvDataAllItems.Columns[9].FillWeight = 15;
        }

        /// <summary>
        /// This method opens the class updateInventory and send the marked item to the class.
        /// </summary>
        private void updateItem()
        {
            var updateCheck = dgvDataAllItems.SelectedRows.Count;

            if (updateCheck != 0)
            {
                Inventory inventoryToUpdate = dgvDataAllItems.SelectedRows[0].DataBoundItem as Inventory;
                Form updateInventory = new UpdateInventory(this, inventoryToUpdate);
                updateInventory.ShowDialog();
            }
        }

        /// <summary>
        /// This method opens the windows form CreateInventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            Form CreateInventory = new CreateInventory(this, role);
            CreateInventory.ShowDialog();
        }

        /// <summary>
        /// This method deletes an item in the inventory by serial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBySerial_Click(object sender, EventArgs e)
        {
            var deletecheck = dgvDataAllItems.SelectedRows.Count;

            if (deletecheck != 0)
            {
                DialogResult answer = MessageBox.Show(@"Are you sure you want to delete the item?", @"Delete?", MessageBoxButtons.YesNo);

                switch (answer)
                {
                    case DialogResult.Yes:
                        {
                            bool success = false;
                            var deleteItem = dgvDataAllItems.SelectedRows[0].DataBoundItem as Inventory;

                            if (deleteItem != null)
                            {
                                success = inventoryCtr.DeleteItemBySerialNr(deleteItem.serialNr);
                            }

                            if(success == true)
                            {
                                MessageBox.Show("The Item was deleted.");
                            }

                            else
                            {
                                MessageBox.Show("The Item couldn't be deleted.");
                            }
                        }

                        break;

                    case DialogResult.No:
                        {
                            MessageBox.Show(@"Selected item was not deleted");
                            break;
                        }
                }
            }

            dgvDataAllItems.DataSource = inventoryCtr.GetAllInventories();
        }

        /// <summary>
        /// This method refreshes the data grid view dgvDataAllItems.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewAllItems_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        /// <summary>
        /// This method resets the list dgvDataAllItems.
        /// </summary>
        public void RefreshDGV()
        {
            dgvDataAllItems.DataSource = inventoryCtr.GetAllInventories();
            inventories = inventoryCtr.GetAllInventories();
        }

        /// <summary>
        /// this method prints a page of all the items in the data grid view dgvDataAllItems.
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

            foreach (DataGridViewColumn dgvGridCol in dgvDataAllItems.Columns)
            {
                if (dgvDataAllItems.Columns[count].Visible == true)
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
                foreach (DataGridViewColumn GridCol in dgvDataAllItems.Columns)
                {
                    if (dgvDataAllItems.Columns[count].Visible == true)
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
            while (iRow <= dgvDataAllItems.RowCount - 1 && bMorePagesToPrint == false)
            {
                DataGridViewRow GridRow = dgvDataAllItems.Rows[iRow];

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

                        e.Graphics.DrawString("Item Summary",
                            new Font(dgvDataAllItems.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left,
                            e.MarginBounds.Top - e.Graphics.MeasureString("Item Summary",
                            new Font(dgvDataAllItems.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToLongDateString() + " " +
                            DateTime.Now.ToShortTimeString();

                        //Draw Date
                        e.Graphics.DrawString(strDate,
                            new Font(dgvDataAllItems.Font, FontStyle.Bold), Brushes.Black,
                            e.MarginBounds.Left +
                            (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                            new Font(dgvDataAllItems.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Width),
                            e.MarginBounds.Top - e.Graphics.MeasureString("Job Summary",
                            new Font(new Font(dgvDataAllItems.Font, FontStyle.Bold),
                            FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        topMargin = e.MarginBounds.Top;
                        check = 0;
                        foreach (DataGridViewColumn GridCol in dgvDataAllItems.Columns)
                        {
                            if (dgvDataAllItems.Columns[count].Visible == true)
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
                        if (dgvDataAllItems.Columns[count].Visible == true)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.Style.Font = new Font("Arial", 5F),
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

        /// <summary>
        /// This method prints out the data grid view dgvDataAllItems.
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
        /// This method opens the class UpdateItem when one of the items in the data grid view dgvDataAllItems is double clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateItem();
        }

        /// <summary>
        /// This method searches after items while the user types in the search box.
        /// </summary>
        private void SearchWhileTyping()
        {
            string search = tbSearchField.Text;
            List<InventoryItem> result = inventories.Where(i => i.Name.ToLower().Contains(search) || i.SerialNo.ToLower().Contains(search) || i.Location.ToLower().Contains(search) || i.Manufacturer.ToLower().Contains(search) || i.Suppliers.ToLower().Contains(search)).ToList();
            dgvDataAllItems.DataSource = result;
        }

        /// <summary>
        /// This method activates when the text in the text box tbSearchField changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSearchField_TextChanged(object sender, EventArgs e)
        {
            SearchWhileTyping();
        }

        /// <summary>
        /// This method checks if the items meets the minimum amount of items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimumAmountCheck_Click(object sender, EventArgs e)
        {
            if (inventoryCtr.findAllItemsNotMinim() == null)
            {
                MessageBox.Show(@"All items meet the minimum requirement");
            }

            else
            {
                dgvDataAllItems.DataSource = inventoryCtr.findAllItemsNotMinim();
            }
        }

        /// <summary>
        /// This method paints the rows if the amount is equal or under the minimum amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDataAllItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDataAllItems.Rows)
            {
                InventoryItem item = row.DataBoundItem as InventoryItem;
                if (item.Amount < item.MinimumAmount)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

                if (item.Amount == item.MinimumAmount)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        /// <summary>
        /// This method calls the updateItem method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            updateItem();
        }
    }
}