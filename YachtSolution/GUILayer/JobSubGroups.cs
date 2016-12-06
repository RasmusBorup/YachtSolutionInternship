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
    /// This is the class JobSubGroups.
    /// </summary>
    public partial class JobSubGroups : MyFormPage
    {
        private SubGroupController sgCtrl;
        private SubGroupDB sgDB;

        /// <summary>
        /// This is the constructor for the class JobSubGroups.
        /// </summary>
        public JobSubGroups()
        {
            InitializeComponent();
            this.panel = SubGroupPanel;
            sgCtrl = SubGroupController.GetInstance();
            sgDB = SubGroupDB.getInstance();

            /*****************GridView-AllGroups*****************************/
            dgvSubGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubGroups.DataSource = sgCtrl.GetAllSubGroups();

            dgvSubGroups.Columns[0].HeaderText = @"ID";
            dgvSubGroups.Columns[1].HeaderText = @"Name";

            /*****************ComboBox-ChooseGroup***************************/
            cbSubGroup.DataSource = sgCtrl.GetAllSubGroups();
            
            cbSubGroup.DisplayMember = "Name";
            cbSubGroup.ValueMember = "ID";

            /*****************Reset*****************************************/
            Reset();
        }

        /// <summary>
        /// This method creates a sub group.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveGroup_Click(object sender, EventArgs e)
        {
            string name = txtSubGroup.Text;

            try
            {
                if(txtSubGroup.Text != "")
                {
                    if(sgCtrl.FindSubGroupByName(name) == "")
                    {
                        string grp = txtSubGroup.Text;
                        bool success = sgCtrl.InsertSubGroup(grp);

                        if(success == true)
                        {
                            MessageBox.Show("The sub group has been created");
                        }

                        else
                        {
                            MessageBox.Show("The sub group couldn't be created");
                        }

                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("There is already a Sub-Group: " + name);
                    }
                }
                else
                {
                    MessageBox.Show("You must give the group a name");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("GUI Error: " + ex);
            }
        }

        /// <summary>
        /// This method resets the data grid view dgvSubGroups.
        /// </summary>
        public void Reset()
        {
            dgvSubGroups.DataSource = sgCtrl.GetAllSubGroups();
        }

        /// <summary>
        /// This method gets a specific sub group.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetGroup_Click(object sender, EventArgs e)
        {
            string b = cbSubGroup.SelectedValue.ToString();
            int i = Int32.Parse(b);

            dgvSubGroups.DataSource = sgCtrl.FindGroupByID(i);

            Console.WriteLine("Index: " + cbSubGroup.SelectedIndex);
        }

        /// <summary>
        /// This method is an action listener for the button btnReset.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// This method deletes a sub group.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = dgvSubGroups.Rows[dgvSubGroups.SelectedRows[0].Index].Cells[1].Value.ToString();
            string j = dgvSubGroups.Rows[dgvSubGroups.SelectedRows[0].Index].Cells[0].Value.ToString();
            int g = Int32.Parse(j);

            try
            {
                sgCtrl.DeleteSubGroup(g);

                MessageBox.Show("Sub-Group " + name + " was deleted.");

                Reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sub-Group " + name + " was not deleted." + ex);
            }
        }
    }
}