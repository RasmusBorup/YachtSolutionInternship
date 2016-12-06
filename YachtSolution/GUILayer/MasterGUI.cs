using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using YachtSolution.ControlLayer;
using YachtSolution.Properties;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class MasterGUI and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class MasterGUI : MyFormPage
    {
        private Login login;
        private SettingsController sCTR;

        /// <summary>
        /// This is the constructor for the class MasterGUI.
        /// </summary>
        public MasterGUI()
        {
            InitializeComponent();
            panel = panel1;
            sCTR = SettingsController.GetInstance();
        }

        /// <summary>
        /// This is the constructor for the class MasterGUI.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="login"></param>
        public MasterGUI(string user, Login login)
        {
            InitializeComponent();
            panel = panel1;
            this.login = login;
            sCTR = SettingsController.GetInstance();

            List<string> tabs = sCTR.GetTabs(user);
            if (user != "Administrator")
            {
                if (tabs.Contains("LogBook"))
                {
                    tabControl.TabPages.Add(new MyTabPage(new LogBook()));
                }
                if (tabs.Contains("Jobs"))
                {
                    tabControl.TabPages.Add(new MyTabPage(new ListOfJobs(user)));
                }
                if (tabs.Contains("Inventory"))
                {
                    tabControl.TabPages.Add(new MyTabPage(new InventoryManagement(user)));
                }
                if (tabs.Contains("Employee Management"))
                {
                    tabControl.TabPages.Add(new MyTabPage(new ListOfEmployees()));
                }
            }
            else
            {
                tabControl.TabPages.Add(new MyTabPage(new LogBook()));
                tabControl.TabPages.Add(new MyTabPage(new ListOfJobs(user)));
                tabControl.TabPages.Add(new MyTabPage(new InventoryManagement(user)));
                tabControl.TabPages.Add(new MyTabPage(new ListOfEmployees()));
            }

            tabControl.TabPages.Add(new MyTabPage(new Settings(this, user)));
        }

        /// <summary>
        /// This method log the user out of the system.
        /// </summary>
        public void LogOut()
        {
            login.LogOut();
        }
    }
}