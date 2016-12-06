using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateReading and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class UpdateReading : Form
    {
        private ReadingsController _rCTR;
        private Readings reading;
        private Reading readingToUpdateChecker;
        

        /// <summary>
        /// This is the constructor for the class UpdateReading.
        /// </summary>
        public UpdateReading()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the constructor for the class UpdateReading.
        /// </summary>
        /// <param name="readingToUpdate"></param>
        /// <param name="reading"></param>
        public UpdateReading(Reading readingToUpdate, Readings reading)
        {
            _rCTR = ReadingsController.GetInstance();
            InitializeComponent();
            tbMachineName.Text = readingToUpdate.machineName;
            tbServicedBy.Text = readingToUpdate.servicedBy;
            tbOldValue.Text = readingToUpdate.oldValue.ToString();
            tbNewValue.Text = readingToUpdate.newValue.ToString();
            tbOldTimeStamp.Text = readingToUpdate.OldTimeStamp.ToString();
            tbReadId.Text = readingToUpdate.readId.ToString();
            tbUnitOfMeasurement.Text = readingToUpdate.UnitOfMeasurement;
            tbMachineUsedFor.Text = readingToUpdate.MachineUsedFor;
            tbHourCounter.Text = readingToUpdate.hourCounter.ToString();
            tbMaintainAtHours.Text = readingToUpdate.maintainAtHours.ToString();

            this.reading = reading;
            this.readingToUpdateChecker = readingToUpdate;

        }

        /// <summary>
        /// This method checks if hour1 is bigger than hour2.
        /// </summary>
        /// <returns>success</returns>
        public bool ReadingHourChecker()
        {
            var success = false;
            var hour1 = Convert.ToInt32(readingToUpdateChecker.hourCounter);
            var hour2 = Convert.ToInt32(tbHourCounter.Text);

            if (hour1 > hour2)
            {
                success = true;
                tbHourCounter.BackColor = Color.Yellow;
                tbHourCounter.Text = readingToUpdateChecker.hourCounter.ToString();
            }
            return success;
        }

        /// <summary>
        /// This method updates a reading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateReading_Click(object sender, EventArgs e)
        {
            if (!ReadingHourChecker())
            {
                if (tbNewValue.Text.ToCharArray().Any(char.IsLetter))
                {
                    MessageBox.Show(@"The measurement box can only contain numbers");
                }
                else
                {
                    var readId = Convert.ToInt32(tbReadId.Text);
                    var machineName = tbMachineName.Text;
                    var servicedBy = tbServicedBy.Text;
                    var oldValue = Convert.ToDouble(tbOldValue.Text);
                    Double newValue = 0;
                    try
                    {
                        newValue = Convert.ToDouble(tbNewValue.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The measurement box can not be empty", @"Error");
                        Console.WriteLine("Error Message: " + ex);
                    }
                    var oldTimeStamp = DateTime.Parse(tbOldTimeStamp.Text);
                    var timeStamp = DateTime.Now;
                    var unitOfMeasurement = tbUnitOfMeasurement.Text;
                    var machineUsedfor = tbMachineUsedFor.Text;
                    int hourCounter = Convert.ToInt32(tbHourCounter.Text);
                    int maintainAtHours = Convert.ToInt32(tbMaintainAtHours.Text);


                    if (tbMachineName.TextLength == 0)
                    {
                        MessageBox.Show(@"The machine name box can not be empty");
                    }
                    else if (tbServicedBy.TextLength == 0)
                    {
                        MessageBox.Show(@"The 'serviced by' box can not be empty");
                    }
                    else if (tbMachineName.TextLength != 0 && tbServicedBy.TextLength != 0 && tbNewValue.TextLength != 0)
                    {
                        DialogResult checker = MessageBox.Show(@"Are you sure you want to update this reading? ",
                            @"Are you sure?", MessageBoxButtons.YesNo);
                        switch (checker)
                        {
                            case DialogResult.No:
                            {
                                MessageBox.Show(@"The measurement was not saved.", @"Are you sure?");
                                break;
                            }
                            case DialogResult.Yes:
                            {

                                bool success = _rCTR.UpdateReadingByReadId(readId, machineName, newValue, oldValue,
                                    servicedBy, oldTimeStamp, timeStamp, unitOfMeasurement, machineUsedfor,
                                    hourCounter, maintainAtHours);
                                reading.RefreshReadingsList();
                                Close();
                                Dispose();

                                if (success == true)
                                {
                                    MessageBox.Show("The Reading has been updated.");
                                }

                                else
                                {
                                    MessageBox.Show("The Reading couldn't be updated.");
                                }

                                break;
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please check the hour counter box, it can not be less than the previous reading", "Error");
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
        }

        /// <summary>
        /// This method checks on keypress whether or not the input for tbNewValue contains letters or more than one comma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNewValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(tbNewValue.Text, @","))
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
        /// This method checks on keypress whether or not the input for name contains letters or more than one comma.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="e"></param>
        private static void NumberChecker(Control name, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(name.Text, @","))
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57)|| e.KeyChar == 08)
                {
                    return;
                }
            }
            else
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        /// <summary>
        /// This method call the NumberChecker method when there is a key press on the text box tbMaintainAtHours.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbMaintainAtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(tbMaintainAtHours, e);
        }

        /// <summary>
        /// This method call the NumberChecker method when there is a key press on the text box tbHourCounter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHourCounter_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(tbHourCounter, e);
        }

    }
}