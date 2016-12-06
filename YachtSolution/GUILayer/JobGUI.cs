using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class JobGUI.
    /// </summary>
    public partial class JobGUI : Form
    {
        /// <summary>
        /// This is the constructor for the class JobGUI.
        /// </summary>
        public JobGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method opens the CreateJob interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateJobClick(object sender, EventArgs e)
        {
            Form create_job = new CreateJob();
            create_job.Show();
            this.Close();
        }

        /// <summary>
        /// This method opens the ListJobs interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListJobsClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method opens the UpdateJob interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateJobClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method opens the DeleteJob interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteJobClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method open the previous interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method open the MainMenu interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuClick(object sender, EventArgs e)
        {

        }
    }
}