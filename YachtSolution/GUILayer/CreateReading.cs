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
    /// This is the class CreateReading and is a subclass to the class Form.
    /// </summary>
    public partial class CreateReading : Form
    {
        private ReadingsController _rCTR;
        private Readings reading;

        /// <summary>
        /// This is the constructor for the class CreateReading.
        /// </summary>
        /// <param name="reading"></param>
        public CreateReading(Readings reading)
        {
            InitializeComponent();
            this.reading = reading;
            _rCTR = ReadingsController.GetInstance();
        }

        /// <summary>
        /// This method creates a reading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateReading_Click(object sender, EventArgs e)
        {

            if (tbMachineName.TextLength == 0 || tbNewValue.TextLength == 0 || tbServicedBy.TextLength == 0 || tbUnitOfMeasurement.TextLength == 0 || tbMachineUsedFor.TextLength == 0 || tbHourCounter.TextLength == 0 || tbMaintainAtHours.TextLength == 0)
            {
                MessageBox.Show(@"Check the boxes, they can not be empty and the reading value box can not contain letters");
            }

            else
            {
                string machineName = tbMachineName.Text;
                double newValue = Convert.ToDouble(tbNewValue.Text);
                string servicedBy = tbServicedBy.Text;
                string unitOfMeasurement = tbUnitOfMeasurement.Text;
                string machineUsedFor = tbMachineUsedFor.Text;
                int hourCounter = Convert.ToInt32(tbHourCounter.Text);
                int maintainAtHours = Convert.ToInt32(tbMaintainAtHours.Text);


                bool success = _rCTR.InsertReading(machineName, newValue, servicedBy, unitOfMeasurement, machineUsedFor, hourCounter, maintainAtHours);

                if (success == true)
                {
                    MessageBox.Show("The reading has been saved.");
                    reading.RefreshReadingsList();
                    Close();
                    Dispose();
                }

                else
                {
                    MessageBox.Show("The reading couldn't the saved.");
                }
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNewValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberChecker(tbNewValue, e);
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