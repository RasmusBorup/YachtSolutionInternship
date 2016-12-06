using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
    /// This is the class Settings and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class Settings : MyFormPage
    {
        private MasterGUI masterGui;
        private SettingsController settingsCtr;
        private string role;

        /// <summary>
        /// This is the constructor for the class Settings.
        /// </summary>
        /// <param name="master"></param>
        public Settings(MasterGUI master, string role)
        {
            InitializeComponent();
            panel = panelLogout;
            masterGui = master;
            settingsCtr = SettingsController.GetInstance();
            SetRoleCB();
            this.role = role;
            SetCheckBoxes();
            if (role != "Administrator")
            {
                gbAdministration.Enabled = false;
                gbAdministration.Visible = false;
            }
        }

        private void SetRoleCB()
        {
            cbRoles.DataSource = settingsCtr.GetRoles().Where(s => s != "Administrator").ToList();
        }

        private void SetCheckBoxes()
        {
            chbEmployees.Checked = false;
            chbInventory.Checked = false;
            chbJobs.Checked = false;
            chbLogbook.Checked = false;
            List<string> tabs = new List<string>();
            if (cbRoles.SelectedItem != null)
            {
                tabs = settingsCtr.GetTabs(cbRoles.SelectedItem.ToString());
            }
            if (tabs.Contains("LogBook"))
            {
                chbLogbook.Checked = true;
            }
            if (tabs.Contains("Jobs"))
            {
                chbJobs.Checked = true;
            }
            if (tabs.Contains("Inventory"))
            {
                chbInventory.Checked = true;
            }
            if (tabs.Contains("Employee Management"))
            {
                chbEmployees.Checked = true;
            }
        }

        /// <summary>
        /// This method log a user out of the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            masterGui.LogOut();
        }

        /// <summary>
        /// This method call the FillDatabase method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillDatabase_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to do this now? It might take several minutes depending on your computer and your connection to the database and a restart of the system is needed.", "Warning", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                if (settingsCtr.FillDatabase())
                {
                    MessageBox.Show("Default data loaded into the database, please restart the program now.");
                    SetRoleCB();
                }
                else
                {
                    MessageBox.Show("Error, Please restart the system before attempting to fill the database again.");
                }
                btnFillDatabase.Enabled = false;
            }
        }

        /// <summary>
        /// This method shows a message box that tells whether the method RemoveUnusedImagesFromDatabase has succeeded or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveUnusedImages_Click(object sender, EventArgs e)
        {
            if (settingsCtr.RemoveUnusedImagesFromDatabase())
            {
                MessageBox.Show("Unused images was successfully removed from the database.");
            }
            else
            {
                MessageBox.Show("Something went wrong when trying to delete unused images.");
            }
        }

        private void cbRoles_TextChanged(object sender, EventArgs e)
        {
            SetCheckBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingsCtr.SaveTabs(cbRoles.SelectedItem.ToString(), chbLogbook.Checked, chbJobs.Checked, chbInventory.Checked, chbEmployees.Checked);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbRoles.SelectedItem != null)
            {
                string roleToDelete = cbRoles.SelectedItem.ToString();
                DialogResult answer = MessageBox.Show("Are you sure you want to delete the selected role?", "Warning",
                    MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    if (settingsCtr.DeleteRole(roleToDelete))
                    {
                        MessageBox.Show("The role was removed from the database.");
                        SetRoleCB();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no roles to delete.");
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string role = tbNewRole.Text;
            if (tbNewRole.Text != "")
            {
                if (tbNewRole.Text.Length <= 50)
                {
                    if (settingsCtr.CreateRole(role))
                    {
                        MessageBox.Show("Role Succesfully saved in the database.");
                        tbNewRole.Text = "";
                        SetRoleCB();
                    }
                    else
                    {
                        MessageBox.Show("The Role is allready in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Please keep the amount of characters for the new role below 50.");
                }
            }
            else
            {
                MessageBox.Show("Please type something in the messagebox above.");
            }
        }
    }
}