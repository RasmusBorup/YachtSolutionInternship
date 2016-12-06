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

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateLogItem and is a subclass to the class Form.
    /// </summary>
    public partial class CreateLogItem : Form
    {
        private LogBookController logbookCtr;
        private LogBook logbook;
        //private Button btnRegisterAll;

        /// <summary>
        /// This is the constructor for the class CreateLogItem.
        /// </summary>
        /// <param name="lb"></param>
        public CreateLogItem(LogBook logbook)
        {
            InitializeComponent();
            logbookCtr = LogBookController.GetInstance();
            this.logbook = logbook;
        }

        /// <summary>
        /// This method creates a log item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string logItemName = tbLogItemName.Text;
            string unitOfMeasurement = tbUnitOfMeasurement.Text;
            string description = rtbDescription.Text;

            if (logItemName != "" && unitOfMeasurement != "")
            {
                if (logbookCtr.CreateLogItem(logItemName, unitOfMeasurement, description))
                {
                    MessageBox.Show("The new log item was successfully saved in the database.");
                    logbook.ShowDGVReadings();
                    CloseCreate();
                }

                else
                {
                    MessageBox.Show("The new item could not be saved in the database. Maybe it is already in the list?");
                }
            }

            else
            {
                MessageBox.Show("Please make sure the item name and unit of measurement fields are filled");
            }
        }

        /// <summary>
        /// This method calls the method CloseCreate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseCreate();
        }

        /// <summary>
        /// This method Closes this windows form.
        /// </summary>
        private void CloseCreate()
        {
            logbook.ShowDGVReadings();
            Close();
            Dispose();
        }
    }
}