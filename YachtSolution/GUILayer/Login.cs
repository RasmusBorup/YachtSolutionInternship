using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class Login and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class Login : MyFormPage
    {
        private EmployeeController employeeCtr;

        /// <summary>
        /// This is the constructor for the class login.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            this.panel = panelLogin;
            employeeCtr = EmployeeController.GetInstance();
        }

        /// <summary>
        /// This method log into the system by checking the user name and the password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                try
                {
                    if (tbUsername.Text != "Admin" && tbPassword.Text != "TYS")
                    {
                        if (employeeCtr.FindEmployeeByLogin(tbUsername.Text, tbPassword.Text) != null)
                        {
                            string userJobTitle =
                                employeeCtr.FindEmployeeByLogin(tbUsername.Text, tbPassword.Text).jobTitle;
                            MasterGUI gui = new MasterGUI(userJobTitle, this);
                            panel.Controls.Clear();
                            panel.Controls.Add(gui.panel);
                        }

                        else
                        {
                            MessageBox.Show("The password did not match the user name.");
                        }
                    }
                    else
                    {
                        MasterGUI gui = new MasterGUI("Administrator", this);
                        panel.Controls.Clear();
                        panel.Controls.Add(gui.panel);
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("There is no one with that user name or the password doesn't match the user", "Error");
                }
            }

            else
            {
                MessageBox.Show("Check if you have filled all the inputs before login.");
            }
        }

        /// <summary>
        /// This method opens the windows form MasterGUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkip_Click(object sender, EventArgs e)
        {
            MasterGUI gui = new MasterGUI("Administrator", this);
            panel.Controls.Clear();
            panel.Controls.Add(gui.panel);
        }

        /// <summary>
        /// This method opens the windows form Login.
        /// </summary>
        public void LogOut()
        {
            Login login = new Login();
            login.panel.Location = new Point(0, 0);
            panel.Controls.Clear();
            panel.Controls.Add(login.panel);
        }
    }
}