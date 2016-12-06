using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;
using YachtSolution.GUILayer;
using YachtSolution.ModelLayer;

namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class SettingsController.
    /// </summary>
    public sealed class SettingsController
    {
        private static object _syncRoot = new Object();
        private static volatile SettingsController _instance;

        private SettingsDB sDB;
        private LogBookController logbookCtr;
        private EmployeeController empCtr;
        private JobController jobCtr;
        private InventoryController invCtr;
        private ImageController imgCtr;

        /// <summary>
        /// This is the constructor for the class SettingsController.
        /// </summary>
        private SettingsController()
        {
            logbookCtr = LogBookController.GetInstance();
            empCtr = EmployeeController.GetInstance();
            jobCtr = JobController.GetInstance();
            invCtr = InventoryController.GetInstance();
            imgCtr = ImageController.GetInstance();
            sDB = SettingsDB.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class SettingsController.
        /// </summary>
        /// <returns></returns>
        public static SettingsController GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new SettingsController();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// This method removes the images that aren't used in the database.
        /// </summary>
        /// <returns>boolean</returns>
        public bool RemoveUnusedImagesFromDatabase()
        {
            List<Employee> res1 = empCtr.ListAllEmployees().Where(x => x.photo != null).Distinct().ToList();
            List<Job> res2 = jobCtr.ListAllJobs().Where(x => x.photo != null).Distinct().ToList();
            //List<InventoryItem> res3 = invCtr.GetAllInventories().Where(x => x.photodoc != null).Distinct().ToList();
            List<int> res4 = imgCtr.GetAllImageIds();

            try
            {
                foreach (Employee employee in res1)
                {
                    res4.Remove(employee.DBImage.ImageID);
                }

                foreach (Job job in res2)
                {
                    res4.Remove(job.DBImage.ImageID);
                }

                //foreach (Inventory inventory in res3)
                //{
                //    res4.Remove(inventory.DBImage.ImageID);
                //}
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                if (res4.Count > 0)
                {
                    for (int i = 0; i < res4.Count; i++)
                    {
                        imgCtr.DeleteImageById(res4[i]);
                    }
                }

                return true;
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        /// <summary>
        /// this method creates logbooks.
        /// </summary>
        public bool FillDatabase()
        {
            if (logbookCtr.FillDatabase() && sDB.DefaultRoles() && sDB.DefaultTabs())//Insert other methods here that adds default data and returns a boolean value indicating success
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetRoles()
        {
            return sDB.GetRoles();
        }

        public List<string> GetTabs(string role)
        {
            return sDB.GetTabs(role);
        }

        public void SaveTabs(string role, bool logbook, bool jobs, bool inventory, bool employees)
        {
            sDB.SaveTabs(role, logbook, jobs, inventory, employees);
        }

        public bool DeleteRole(string role)
        {
            return sDB.DeleteRole(role);
        }

        public bool CreateRole(string role)
        {
            return sDB.CreateRole(role);
        }
    }
}
