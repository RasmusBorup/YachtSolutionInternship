using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateJob and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class UpdateJob : Form
    {
        private JobController jobCtr;
        private LogBookController logBookCtr;
        private Job jobToUpdate;
        private ListOfJobs list;
        private string userRole;
        private string tbWorkerInitText = "Who finished the job?";
        private bool edited;

        /// <summary>
        /// This is the constructor for the class UpdateJob.
        /// </summary>
        /// <param name="jobToUpdate"></param>
        public UpdateJob(Job jobToUpdate, ListOfJobs list, string userRole)
        {
            InitializeComponent();
            this.jobToUpdate = jobToUpdate;
            jobCtr = JobController.GetInstance();
            logBookCtr = LogBookController.GetInstance();
            this.list = list;
            this.SuspendLayout();
            this.userRole = userRole;

            cbSubGroup.DataSource = jobCtr.GetAllSubGroups();
            List<string> logItems = new List<string>();
            foreach (LogItem logItem in logBookCtr.GetAllLogItems())
            {
                logItems.Add(logItem.logItem1);
            }
            cbLogItems.DataSource = logItems;

            cbSubGroup.DisplayMember = "Name";
            this.Name = "UpdateJob";
            this.ResumeLayout(false);
            tbTitle.Text = jobToUpdate.title;
            tbDescription.Text = jobToUpdate.description;
            tbNote.Text = jobToUpdate.note;
            chbJobDone.Checked = jobToUpdate.done;
            numTimeBetweenJobs.Value = jobToUpdate.timeBetweenJobs;
            cbSubGroup.Text = jobToUpdate.subGroup;
            if (jobToUpdate.logItem != "")
            {
                cbLogItems.Text = jobToUpdate.logItem;
            }
            else
            {
                cbLogItems.Enabled = false;
            }
            pbPhoto.Image = jobCtr.GetImage(jobToUpdate.photo);

            if (jobToUpdate.nameOfEmployee == "")
            {
                tbWorker.Text = tbWorkerInitText;
                tbWorker.ForeColor = Color.Gray;

                if (!chbJobDone.Checked)
                {
                    tbWorker.Enabled = false;
                }
            }

            else
            {
                tbWorker.Text = jobToUpdate.nameOfEmployee;
            }
        }

        /// <summary>
        /// This method updates a job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateJobButton_Click(object sender, EventArgs e)
        {
            bool success = false;
            string message;

            int jobID = jobToUpdate.id;
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            string nameOfEmployee;

            if (tbWorker.Text != tbWorkerInitText)
            {
                nameOfEmployee = tbWorker.Text;
            }

            else
            {
                nameOfEmployee = "";
            }

            int jobFrequency = (int)numTimeBetweenJobs.Value;
            string note = tbNote.Text;
            bool jobDone = chbJobDone.Checked;
            string sg = cbSubGroup.Text;
            string item = cbLogItems.Text;

            if (title != "" && description != "")
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
                            pbPhoto.Image = jobCtr.GetImage(jobToUpdate.photo);
                            pbPhoto.ImageLocation = "";
                            MessageBox.Show("Please do not use images larger than 5mb.");
                            return;
                        }
                    }
                }

                bool isRoutineJob = jobCtr.CheckIfRoutine(jobToUpdate.id);

                if (isRoutineJob) //if it is a routine job
                {
                    if (chbJobDone.Checked == jobToUpdate.done)
                    {
                        //Ask if the whole routine is to be updated
                        DialogResult answer = MessageBox.Show("Do you want to update the whole routine? " +
                                                              "If you click yes all jobs in the same routine as this one will be updated. " +
                                                              "If you click No only this one will be updated", "Warning",
                            MessageBoxButtons.YesNoCancel);
                        if (answer == DialogResult.Yes)
                        {
                            success = jobCtr.UpdateJob(jobID, title, description, nameOfEmployee, jobFrequency, jobDone, note,
                                userRole, true, photo, sg, item);
                        }

                        else if (answer == DialogResult.No)
                        {
                            success = jobCtr.UpdateJob(jobID, title, description, nameOfEmployee, jobFrequency, jobDone, note,
                                userRole, false, photo, sg, item);
                        }

                        else
                        {
                            return;
                        }
                    }

                    else
                    {
                        success = jobCtr.UpdateJob(jobID, title, description, nameOfEmployee, jobFrequency, jobDone, note,
                            userRole, false, photo, sg, item);
                    }

                }

                else
                {
                    success = jobCtr.UpdateJob(jobID, title, description, nameOfEmployee, jobFrequency, jobDone, note, userRole, false, photo, sg, item);
                }

                if (success)
                {
                    message = "The job was successfully saved in the database";
                }

                else
                {
                    message = "The job could not be saved in the database";
                }
            }

            else
            {
                message = "Please confirm that the necessary text field are filled out";
            }

            if (success && MessageBox.Show(message) == DialogResult.OK)
            {
                list.DynamicSearch();
                this.Dispose();
                this.Close();
            }

            else
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// This method deletes a job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteJob_click(object sender, EventArgs e)
        {
            string message;
            bool success = false;
            //Check if it is a routine job
            bool isRoutineJob = jobCtr.CheckIfRoutine(jobToUpdate.id);

            if (isRoutineJob) //if it is a routine job
            {
                //Ask if the whole routine is to be updated
                DialogResult answer = MessageBox.Show("Do you want to delete the whole routine? +" +
                                                      " If you click yes all jobs in the same routine as this one will be deleted. " +
                                                      "If you click No only this one will be deleted", "Warning", MessageBoxButtons.YesNoCancel);

                if (answer == DialogResult.Yes)
                {
                    success = jobCtr.DeleteJob(jobToUpdate.id, true);//Delete the whole routine
                }

                else if (answer == DialogResult.No)
                {
                    success = jobCtr.DeleteJob(jobToUpdate.id, false);
                }

                else
                {
                    return;
                }
            }

            else
            {
                success = jobCtr.DeleteJob(jobToUpdate.id, false);
            }

            this.Close();
            list.DynamicSearch();

            if (isRoutineJob)
            {
                if (success)
                {
                    message = "The jobs have been deleted";
                }

                else
                {
                    message = "The jobs couldn't be deleted.";
                }
            }

            else
            {
                if (success)
                {
                    message = "The job have been deleted";
                }

                else
                {
                    message = "The job couldn't be deleted.";
                }
            }

            MessageBox.Show(message);
        }

        /// <summary>
        /// This method lets the user find an image to the job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = jobCtr.BrowseImage();
        }

        /// <summary>
        /// This method opens the windows form UpdateSubGroup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateSubGroup_Click(object sender, EventArgs e)
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
        /// This method opens the windows form CreateGroup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSubgroup_Click(object sender, EventArgs e)
        {
            CreateGroup cg = new CreateGroup(cbSubGroup);
            cg.Text = "New Group";
            cg.ShowDialog();
        }

        /// <summary>
        /// This method closes tis windows form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        /// <summary>
        /// This method changes the fore color on the text box tbWorker to black when it is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbWorker_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbWorker.ForeColor = Color.Black;
            edited = !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// This method changes the fore color on the text box tbWorker to gray and clears the text box when the keyboard key Enter is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbWorker_Enter(object sender, EventArgs e)
        {
            if (!edited)
            {
                tbWorker.ForeColor = Color.Gray;
                tbWorker.Clear();
            }
        }

        /// <summary>
        /// This method changes the fore color on the text box tbWorker to gray when it is no longer the active text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbWorker_Leave(object sender, EventArgs e)
        {
            if (!edited)
            {
                tbWorker.ForeColor = Color.Gray;
                tbWorker.Text = tbWorkerInitText;
            }
        }

        /// <summary>
        /// This method enables or disables the text box tbWorker when the value in the check box chbJobDone has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbJobDone_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJobDone.Checked)
            {
                tbWorker.Enabled = true;
            }

            else
            {
                tbWorker.Enabled = false;
            }
        }
    }
}