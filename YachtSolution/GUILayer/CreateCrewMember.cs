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
    /// This is the class CreateCrewMember and is a subclass to the class Form.
    /// </summary>
    public partial class CreateCrewMember : Form
    {
        private EmployeeController employeeCtr;
        private SettingsController settingsCTR;
        private ListOfEmployees list;

        /// <summary>
        /// This is the constructor for the class CreateCrewMember.
        /// </summary>
        public CreateCrewMember(ListOfEmployees list)
        {
            InitializeComponent();
            employeeCtr = EmployeeController.GetInstance();
            settingsCTR = SettingsController.GetInstance();
            this.list = list;
            cbJobRole.DataSource = settingsCTR.GetRoles();
        }

        /// <summary>
        /// This method creates an employee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool filled = true;
            bool success = false;
            bool salaryFail = false;
            string name = tbName.Text;
            string jobEmail = tbEmail.Text;
            string jobPhone = tbPhone.Text;
            string ssn = tbSSN.Text;
            double salary = 0;
            string userName = tbUserName.Text;
            string passWord = tbPassWord.Text;
            string jobTitle = "";
            if (cbJobRole.SelectedItem != null)
            {
                jobTitle = cbJobRole.SelectedItem.ToString();
            }
            try
            {
                new System.Net.Mail.MailAddress(jobEmail);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("there have to be an email.");
                filled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("The Email isn't valid.");
                filled = false;
            }

            try
            {
                salary = Convert.ToDouble(tbSalary.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Salary must be a decimal number. Error: " + exception);
                salaryFail = true;
                filled = false;
            }

            Employee employee = employeeCtr.FindEmployeeBySsn(ssn);

            if (employee != null)
            {
                string message = "There exists already an employee with the same CPR. Do you want to replace the employee?";

                if(MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (name != "" && jobTitle != "" && jobEmail != "" && jobPhone != "" && ssn != "" && !salaryFail && filled)
                    {

                        DBImage photo = null;

                        if (!string.IsNullOrEmpty(pbPhoto.ImageLocation))
                        {
                            FileInfo f = new FileInfo(pbPhoto.ImageLocation);
                            if (f.Length < 5000000)
                            {
                                photo = employeeCtr.InsertImage(pbPhoto.ImageLocation);
                            }
                            else
                            {
                                pbPhoto.ImageLocation = "";
                                MessageBox.Show("Please do not use images larger than 5mb.");
                                return;
                            }
                        }

                        success = employeeCtr.UpdateEmployeeByID(employee.idOfEmployee, name, jobTitle, jobEmail, jobPhone, ssn, salary, photo, userName, passWord);
                    }

                    else if (!salaryFail)
                    {
                        MessageBox.Show("The changes was not saved in the database. Please check that all text fields have been filled and a Job Role has been selected.");
                    }
                }
            }

            else
            {
                if (name != "" && jobTitle != "" && jobEmail != "" && jobPhone != "" && ssn != "" && !salaryFail && filled)
                {
                    DBImage photo = null;

                    if (!string.IsNullOrEmpty(pbPhoto.ImageLocation))
                    {
                        FileInfo f = new FileInfo(pbPhoto.ImageLocation);
                        if (f.Length < 5000000)
                        {
                            photo = employeeCtr.InsertImage(pbPhoto.ImageLocation);
                        }
                        else
                        {
                            pbPhoto.ImageLocation = "";
                            MessageBox.Show("Please do not use images larger than 5mb.");
                            return;
                        }
                    }

                    success = employeeCtr.CreateEmployee(name, jobTitle, jobEmail, jobPhone, ssn, salary, photo, userName, passWord);
                }

                else if (!salaryFail)
                {
                    MessageBox.Show("The employee was not saved in the database. Please check that all text fields have been filled.");
                }
            }

            if (success)
            {
                MessageBox.Show("The crew member has been saved.");
                this.Close();
                list.RefreshTable();
            }
        }

        /// <summary>
        /// This method returns the path to the image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = employeeCtr.BrowseImage();
        }

        /// <summary>
        /// This method closes this windows form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}