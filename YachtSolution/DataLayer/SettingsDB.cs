using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.Properties;

namespace YachtSolution.DataLayer
{
    class SettingsDB
    {
        private static SettingsDB instance;
        private DatabaseTableDataContext db;
        private SettingsDB()
        {
            db = new DatabaseTableDataContext();
        }

        public static SettingsDB GetInstance()
        {
            if (instance == null)
            {
                instance = new SettingsDB();
            }
            return instance;
        }

        public List<string> GetRoles()
        {
            List<string> stringRoles = new List<string>();
            try
            {
                List<Role> roles = db.Roles.ToList();
                foreach (Role role in roles)
                {
                    stringRoles.Add(role.role1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return stringRoles;
        }

        public List<string> GetTabs(string role)
        {
            List<string> tabs = new List<string>();
            List<RoleTab> roleTabs = db.RoleTabs.Where(r => r.role == role).ToList();
            foreach (RoleTab roleTab in roleTabs)
            {
                tabs.Add(roleTab.tabName);
            }
            return tabs;
        }

        private Tab FindTab(string tab)
        {
            return db.Tabs.SingleOrDefault(t => t.tab1 == tab);
        }

        public bool CreateRole(string role)
        {
            try
            {
                if (FindRole(role) == null)
                {
                    Role roleToInsert = new Role();
                    roleToInsert.role1 = role;
                    db.Roles.InsertOnSubmit(roleToInsert);
                    db.SubmitChanges();
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return false;
            }
            return true;
        }

        private Role FindRole(string role)
        {
            return db.Roles.SingleOrDefault(r => r.role1 == role);
        }

        private List<RoleTab> FindRoleTabsByRole(string role)
        {
            List<RoleTab> roleTabs = new List<RoleTab>();
            try
            {
                roleTabs = db.RoleTabs.Where(r => r.role == role).ToList();
            }
            catch (Exception)
            {

            }

            return roleTabs;
        }

        private void DeleteRoleTabs(string role)
        {
            try
            {
                db.RoleTabs.DeleteAllOnSubmit(FindRoleTabsByRole(role));

            }
            catch (Exception)
            {

            }
        }

        public bool DeleteRole(string role)
        {
            try
            {
                Role roleToDelete = FindRole(role);
                if (roleToDelete != null)
                {
                    DeleteRoleTabs(role);
                    db.Roles.DeleteOnSubmit(roleToDelete);
                    db.SubmitChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                return false;
            }
            return true;
        }

        private bool CreateTab(string title)
        {
            try
            {
                if (FindTab(title) == null)
                {
                    Tab tab = new Tab();
                    tab.tab1 = title;
                    db.Tabs.InsertOnSubmit(tab);
                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void CreateRoleTab(string role, string tab)
        {
            RoleTab rt = new RoleTab();
            rt.Role1 = FindRole(role);
            rt.Tab = FindTab(tab);
            db.RoleTabs.InsertOnSubmit(rt);
            db.SubmitChanges();
        }

        public void SaveTabs(string role, bool logbook, bool jobs, bool inventory, bool employees)
        {
            try
            {
                RoleTab logTab = db.RoleTabs.SingleOrDefault(r => r.role == role && r.tabName == "LogBook");
                RoleTab jobsTab = db.RoleTabs.SingleOrDefault(r => r.role == role && r.tabName == "Jobs");
                RoleTab invTab = db.RoleTabs.SingleOrDefault(r => r.role == role && r.tabName == "Inventory");
                RoleTab empTab = db.RoleTabs.SingleOrDefault(r => r.role == role && r.tabName == "Employee Management");

                if (!logbook && logTab != null)
                {
                    db.RoleTabs.DeleteOnSubmit(logTab);
                }
                else if (logbook && logTab == null)
                {
                    CreateRoleTab(role, "LogBook");
                }
                if (!jobs && jobsTab != null)
                {
                    db.RoleTabs.DeleteOnSubmit(jobsTab);
                }
                else if (jobs && jobsTab == null)
                {
                    CreateRoleTab(role, "Jobs");
                }
                if (!inventory && invTab != null)
                {
                    db.RoleTabs.DeleteOnSubmit(invTab);
                }
                else if (inventory && invTab == null)
                {
                    CreateRoleTab(role, "Inventory");
                }
                if (!employees && empTab != null)
                {
                    db.RoleTabs.DeleteOnSubmit(empTab);
                }
                else if (employees && empTab == null)
                {
                    CreateRoleTab(role, "Employee Management");
                }
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public bool DefaultRoles()
        {
            CreateRole("Captain");
            CreateRole("Administrator");
            CreateRole("Chief Engineer");
            CreateRole("Chief Officer");
            CreateRole("Chef");
            CreateRole("Chief Stewardess");
            return true;
        }

        public bool DefaultTabs()
        {
            if (CreateTab("LogBook") && CreateTab("Jobs") && CreateTab("Inventory") && CreateTab("Employee Management"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
