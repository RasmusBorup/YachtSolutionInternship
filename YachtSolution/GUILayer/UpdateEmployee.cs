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
    /// This is the class UpdateEmployee and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class UpdateEmployee : Form
    {
        private Employee employeeToUpdate;
        private EmployeeController employeeCtr;
        private SettingsController settingsCTR;
        private ListOfEmployees list;

        /// <summary>
        /// This is the constructor for the class UpdateEmployee.
        /// </summary>
        /// <param name="employeeToUpdate"></param>
        /// <param name="list"></param>
        public UpdateEmployee(Employee employeeToUpdate, ListOfEmployees list)
        {
            InitializeComponent();
            employeeCtr = EmployeeController.GetInstance();
            this.employeeToUpdate = employeeToUpdate;
            settingsCTR = SettingsController.GetInstance();
            cbJobRole.DataSource = settingsCTR.GetRoles();
            tbName.Text = employeeToUpdate.name;
            cbJobRole.Text = employeeToUpdate.jobTitle;
            tbEmail.Text = employeeToUpdate.jobEmail;
            tbPhone.Text = employeeToUpdate.jobPhone;
            tbSSN.Text = employeeToUpdate.ssn;
            tbSalary.Text = employeeToUpdate.salary.ToString();
            pbPhoto.Image = employeeCtr.GetImage(employeeToUpdate.photo);
            tbUserName.Text = employeeToUpdate.userName;
            tbPassWord.Text = employeeToUpdate.passWord;
            this.list = list;
        }

        /// <summary>
        /// This method puts roles in the combo box cbJobRole.
        /// </summary>
        private void Roles()
        {
            cbJobRole.Items.Add("Chief Officer");
            cbJobRole.Items.Add("Chief Stewardess");
            cbJobRole.Items.Add("Chef");
            cbJobRole.Items.Add("Chief Engineer");
            cbJobRole.Items.Add("Captain");
            cbJobRole.Items.Add("Administrator");
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
        /// This method updates an employee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool success = false;
            bool salaryFail = false;
            string name = tbName.Text;
            string jobTitle = cbJobRole.SelectedItem.ToString();
            string jobEmail = tbEmail.Text;
            string jobPhone = tbPhone.Text;
            string ssn = tbSSN.Text;
            double salary = 0;
            string userName = tbUserName.Text;
            string passWord = tbPassWord.Text;

            try
            {
                salary = Convert.ToDouble(tbSalary.Text);
            }

            catch (Exception exception)
            {
                MessageBox.Show("Salary must be a decimal number. Error: " + exception);
                salaryFail = true;
            }

            if (name != "" && jobTitle != "" && jobEmail != "" && jobPhone != "" && ssn != "" && !salaryFail)
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
                        pbPhoto.Image = employeeCtr.GetImage(employeeToUpdate.photo);
                        pbPhoto.ImageLocation = "";
                        MessageBox.Show("Please do not use images larger than 5mb.");
                        return;
                    }
                }
                success = employeeCtr.UpdateEmployeeByID(employeeToUpdate.idOfEmployee, name, jobTitle, jobEmail, jobPhone, ssn, salary, photo, userName, passWord);
            }

            else if (!salaryFail)
            {
                MessageBox.Show(
                    "The changes was not saved in the database. Please check that all text fields have been filled and a Job Role has been selected.");
            }

            if (success)
            {
                MessageBox.Show("The employee has been updated.");
                Close();
                list.RefreshTable();
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
        /// This method deletes the employee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you would like to delete this employee from the system?", "Warning", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                employeeCtr.DeleteEmployee(employeeToUpdate.idOfEmployee);
                MessageBox.Show("The employee have been removed from the system");
                list.RefreshTable();
                Close();
                Dispose();
            }
        }
    }
}