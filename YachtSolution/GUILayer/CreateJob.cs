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
    /// This is the class CreateJob and is a subclass to the class Form.
    /// </summary>
    public partial class CreateJob : Form
    {
        private JobController jobCtr;
        private LogBookController logbookCtr;
        private ListOfJobs list;
        private string userRole;

        /// <summary>
        /// This is the constructor for the class CreateJob.
        /// </summary>
        public CreateJob(ListOfJobs list, string userRole)
        {
            InitializeComponent();
            this.jobCtr = JobController.GetInstance();
            logbookCtr = LogBookController.GetInstance();
            this.list = list;
            UpdateGroupComboBox();
            cbSubGroup.SelectedIndex = -1;
            this.userRole = userRole;
            lblLink.Enabled = false;
            cbLogItems.Enabled = false;
            List<string> logItems = new List<string>();

            foreach (LogItem item in logbookCtr.GetAllLogItems())
            {
                logItems.Add(item.logItem1);
            }

            cbLogItems.DataSource = logItems;
            WorkerTextBox(false);
        }

        /// <summary>
        /// This method creates a job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_button_Click(object sender, EventArgs e)
        {
            bool filled = false;
            bool success = false;
            string message;
            string title = tbTitle.Text;
            bool done_job = chbJobDone.Checked;
            string worker;

            if (done_job == true)
            {
                worker = tbWorker.Text;
            }

            else
            {
                worker = "";
            }

            int time_between_jobs = (int)numTimeBetweenJobs.Value;
            string description = tbDescription.Text;
            string note = tbNote.Text;
            string sg = cbSubGroup.Text;

            if (title != "")
            {
                DBImage photo = null;

                if (!string.IsNullOrEmpty(pbPhoto.ImageLocation))
                {
                    if (!string.IsNullOrEmpty(pbPhoto.ImageLocation))
                    {
                        FileInfo f = new FileInfo(pbPhoto.ImageLocation);
                        if (f.Length < 5000000)
                        {
                            photo = jobCtr.InsertImage(pbPhoto.ImageLocation);
                        }
                        else
                        {
                            pbPhoto.ImageLocation = "";
                            MessageBox.Show("Please do not use images larger than 5mb.");
                            return;
                        }
                    }
                }

                string logitem;

                if (cbLogItems.Enabled)
                {
                    logitem = cbLogItems.Text;
                }
                else
                {
                    logitem = "";
                }

                filled = true;
                success = jobCtr.CreateJob(title, description, note, worker, time_between_jobs, done_job, userRole, photo, sg, logitem, rbDays.Checked, rbHours.Checked);
            }

            if (filled == false)
            {
                message = "Check all text boxes before saving.";
            }

            else
            {
                if (success == false)
                {
                    message = "the job couldn't be saved.";
                }

                else
                {
                    MessageBox.Show("the job is saved");
                    Close();
                    list.DynamicSearch();
                    return;
                }
            }

            MessageBox.Show(message);
        }

        /// <summary>
        /// This method closes this windows form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// This method returns the path to the image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = jobCtr.BrowseImage();
        }

        /// <summary>
        /// This method opens the windows form CreateGroup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            CreateGroup cg = new CreateGroup(cbSubGroup);
            cg.Text = "New Group";
            cg.ShowDialog();
        }

        /// <summary>
        /// This method opens the windows form UpdateSubGroup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            string sg = cbSubGroup.Text;

            if (sg != "")
            {
                UpdateSubGroup ug = new UpdateSubGroup(sg, cbSubGroup);
                ug.Text = "Update Group";
                ug.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to select a 'Main Group'.");
            }
        }

        /// <summary>
        /// This method fills up the combo box cbSubGroup.
        /// </summary>
        public void UpdateGroupComboBox()
        {
            cbSubGroup.DataSource = jobCtr.GetAllSubGroups();
            cbSubGroup.DisplayMember = "Name";
        }

        /// <summary>
        /// This method checks if the value of the radio button rbDays is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDays_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDays.Checked)
            {
                lblLink.Enabled = false;
                cbLogItems.Enabled = false;
                lblFrequencyOfJob.Text = "Frequency of job(In days)";
                lblLeave.Visible = true;
            }
            else
            {
                lblLink.Enabled = true;
                cbLogItems.Enabled = true;
                lblFrequencyOfJob.Text = "Frequency of job(In hours)";
                lblLeave.Visible = false;
            }
        }

        /// <summary>
        /// This method enables or disables the text box tbWorker when the value in the check box chbJobDone has changed.
        /// </summary>
        /// <param name="enabled"></param>
        private void WorkerTextBox(bool enabled)
        {
            tbWorker.Enabled = enabled;
        }

        /// <summary>
        /// This method checks if the value of the check box chbJobDone has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbJobDone_CheckedChanged(object sender, EventArgs e)
        {
            WorkerTextBox(chbJobDone.Checked);
        }
    }
}