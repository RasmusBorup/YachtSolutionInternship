using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    /// This is the class UpdateInventory and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class UpdateInventory : Form
    {
        private InventoryController inventoryCtr;
        private InventoryManagement inv;
        private Inventory inventoryToUpdate;

        /// <summary>
        /// This is the constructor for the class UpdateInventory.
        /// </summary>
        /// <param name="inv"></param>
        /// <param name="inventoryToUpdate"></param>
        public UpdateInventory(InventoryManagement inv, Inventory inventoryToUpdate)
        {
            this.inv = inv;
            this.inventoryToUpdate = inventoryToUpdate;
            inventoryCtr = InventoryController.GetInstance();
            InitializeComponent();

            this.Name = "Inventory handler";
            this.ResumeLayout(false);
            tbName.Text = inventoryToUpdate.name;
            numericUpDownAmount.Value = inventoryToUpdate.amount;
            tbSerialNr.Text = inventoryToUpdate.serialNr;
            tbPrice.Text += inventoryToUpdate.price;
            numericUpDownMinAmount.Value = (decimal)inventoryToUpdate.minimumAmount;
            tbLocation.Text = inventoryToUpdate.location;
            tbManufacturer.Text = inventoryToUpdate.manufacturer;
            rtbDescription.Text = inventoryToUpdate.description;
            tbPartFor.Text = inventoryToUpdate.partFor;
            rtbSuppliers.Text = inventoryToUpdate.suppliers;

            pbPhoto.Image = inventoryCtr.GetImage(inventoryToUpdate.photodoc);
        }

        /// <summary>
        /// This method creates an item in the inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveUpdateItem_Click(object sender, EventArgs e)
        {
            bool success = false;
            string message;

            if (tbSerialNr.Text.Length != 0 && tbPrice.Text.Length != 0)
            {
                string name = tbName.Text;
                int amount = (int)numericUpDownAmount.Value;
                string serial = tbSerialNr.Text;
                string description = rtbDescription.Text;
                double price = Convert.ToDouble(tbPrice.Text);
                int minimumAmount = (int)numericUpDownMinAmount.Value;
                string location = tbLocation.Text;
                string manufacturer = tbManufacturer.Text;
                DBImage photo = null;
                string partFor = tbPartFor.Text;
                string suppliers = rtbSuppliers.Text;


                if (name.Length != 0 && location.Length != 0 && manufacturer.Length != 0)
                {
                    if (!string.IsNullOrEmpty(pbPhoto.ImageLocation))
                    {
                        if (!string.IsNullOrEmpty(pbPhoto.ImageLocation))
                        {
                            FileInfo f = new FileInfo(pbPhoto.ImageLocation);
                            if (f.Length < 5000000)
                            {
                                photo = inventoryCtr.InsertImage(pbPhoto.ImageLocation);
                            }
                            else
                            {
                                pbPhoto.Image = inventoryCtr.GetImage(inventoryToUpdate.photodoc);
                                pbPhoto.ImageLocation = "";
                                MessageBox.Show("Please do not use images larger than 5mb.");
                                return;
                            }
                        }
                    }

                    success = inventoryCtr.UpdateItemBySerialNr(description, amount, location, manufacturer, minimumAmount, name, price, serial, photo, partFor, suppliers);

                    message = success ? "The item was successfully saved in the database" : "The item could not be saved in the database";
                }

                else
                {
                    message = "Please confirm that the necessary text fields are filled out";
                }

                if (success && MessageBox.Show(message, @"Item update succeeded") == DialogResult.OK)
                {
                    this.Dispose();
                    this.Close();
                    inv.RefreshDGV();
                }

                else
                {
                    MessageBox.Show(message, @"Item update failed");
                }

            }

            else
            {
                message = "Please confirm that the necessary text fields are filled out";
                MessageBox.Show(message, @"Item update failed");
            }
        }

        /// <summary>
        /// This method returns the path of the image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = inventoryCtr.BrowseImage();
        }

        /// <summary>
        /// This method closes this windows form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateItemCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        /// <summary>
        /// This method checks on key press whether or not the input for name contains letters or more than one comma.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="e"></param>
        private static void NumberChecker(Control name, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(name.Text, @","))
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 08 || e.KeyChar == 44 || e.KeyChar == 45)
                {
                    return;
                }
            }

            else
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 08 || e.KeyChar == 45)
                {
                    return;
                }
            }

            e.Handled = true;
        }

        /// <summary>
        /// This method call the NumberChecker method when there is a key press on the text box tbPrice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(tbPrice, e);
        }

        /// <summary>
        /// This method call the NumberChecker method when there is a key press on the text box tbSerialNr.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSerialNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(tbSerialNr, e);
        }
    }
}