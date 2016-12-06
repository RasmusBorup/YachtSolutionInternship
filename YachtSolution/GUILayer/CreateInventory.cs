using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateInventory and is a subclass to the class Form.
    /// </summary>
    public partial class CreateInventory : Form
    {
        private InventoryController inventoryCtr;
        private InventoryManagement inv;
        private string role;

        /// <summary>
        /// This is the constructor for the class CreateInventory.
        /// </summary>
        /// <param name="inv"></param>
        public CreateInventory(InventoryManagement inv, string role)
        {
            this.inv = inv;
            this.role = role;
            inventoryCtr = InventoryController.GetInstance();
            InitializeComponent();
        }

        /// <summary>
        /// This method creates an inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            var insertCheck = 0; //inventoryCtr.FindItemBySerialNr(tbSerialNr.Text).Count;

            if (insertCheck == 0 && tbPrice.Text.Length != 0)
            {
                string message = "";
                string name = tbName.Text;
                int amount = (int)numAmount.Value;
                string serial = tbSerialNr.Text;
                string description = rtbDescription.Text;
                double price = Convert.ToDouble(tbPrice.Text);
                int minimumAmount = (int)numMinAmount.Value;
                string location = tbLocation.Text;
                string manufacturer = tbManufacturer.Text;
                DBImage photo = null;
                string partFor = tbPartFor.Text;
                string suppliers = rtbSuppliers.Text;

                if (name.Length != 0 && serial.Length != 0 && location.Length != 0 && manufacturer.Length != 0)
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
                            pbPhoto.ImageLocation = "";
                            MessageBox.Show("Please do not use images larger than 5mb.");
                            return;
                        }
                    }

                    inventoryCtr.InsertItem(name, amount, description, price, minimumAmount, location, manufacturer, serial, partFor, suppliers, role);
                    message = "Item was successfully inserted into the database";
                    this.Dispose();
                    this.Close();
                    inv.RefreshDGV();
                }

                if (name.Length == 0)
                {
                    message = "You have not specified a name for the item";
                }

                else if (serial.Length == 0)
                {
                    message = "You have not specified a Serial Number for the item";
                }

                else if (tbPrice.Text.ToCharArray().Any(c => !char.IsDigit(c)))
                {
                    message = "The price field can only contain numbers";
                }

                else if (location.Length == 0)
                {
                    message = "You have not specified a location for the item";
                }

                else if (manufacturer.Length == 0)
                {
                    message = "You have not specified the manufacturer for the item";
                }

                MessageBox.Show(message, @"Confirmation");

            }

            else
            {
                MessageBox.Show(@"There was an error in creating an item, either the item already exists in the database or there is a problem with the fields", @"Item creation failed");
            }
        }

        /// <summary>
        /// This method closes this windows form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        /// <summary>
        /// This method returns the path to the image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = inventoryCtr.BrowseImage();
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
        /// This method checks on key press whether or not the input for tbNewValue contains letters or more than one comma.
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