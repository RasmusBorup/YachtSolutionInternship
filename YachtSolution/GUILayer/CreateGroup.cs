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
    /// This is the class CreateGroup and is a subclass to the class Form.
    /// </summary>
    public partial class CreateGroup : Form
    {
        private JobController jobCtr;
        private ComboBox cb;

        /// <summary>
        /// This is the constructor for the class CreateGroup.
        /// </summary>
        /// <param name="cb"></param>
        public CreateGroup(ComboBox cb)
        {
            InitializeComponent();
            this.cb = cb;
            jobCtr = JobController.GetInstance();
        }

        /// <summary>
        /// This method creates a sub group.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveGroup_Click(object sender, EventArgs e)
        {
            if (jobCtr.InsertSubGroup(tbName.Text))
            {
                MessageBox.Show("Sub Group saved");
                cb.DataSource = jobCtr.GetAllSubGroups();
                cb.DisplayMember = "Name";
                cb.SelectedItem = jobCtr.GetAllSubGroups().Last();
                Close();
                Dispose();
            }

            else
            {
                MessageBox.Show("Something went wrong");
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
    }
}