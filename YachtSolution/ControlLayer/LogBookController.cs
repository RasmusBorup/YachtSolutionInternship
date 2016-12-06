using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;

namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class LogBookController.
    /// </summary>
    public sealed class LogBookController
    {
        private static object _syncRoot = new Object();
        private static volatile LogBookController _instance;
        private LogBookDB logbookDB;
        private JobController jobCtr;

        /// <summary>
        /// This is the constructor for the class LogBookController.
        /// </summary>
        private LogBookController()
        {
            logbookDB = LogBookDB.GetInstance();
            jobCtr = JobController.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class LogBookController.
        /// </summary>
        /// <returns>_instance</returns>
        public static LogBookController GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new LogBookController();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// This method gets all the logbooks.
        /// </summary>
        /// <returns>logbooks</returns>
        public List<LogBook> GetAllLogBooks()
        {
            return logbookDB.GetAllLogBooks();
        }

        /// <summary>
        /// This method finds logbooks by date.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>logitems</returns>
        public List<LogItem> GetAllLogItems()
        {
            return logbookDB.GetAllLogItems();
        }

        /// <summary>
        /// This method returns all the log item readings.
        /// </summary>
        /// <returns>logItemReading</returns>
        public List<LogItemReading> GetAllLogItemReadings()
        {
            return logbookDB.GetAllLogReadings();
        }

        /// <summary>
        /// This method creates a logbook.
        /// </summary>
        /// <param name="logItemName"></param>
        /// <param name="measurementUnit"></param>
        /// <returns>boolean</returns>
        public bool CreateLogBook(DateTime date, string chiefEngineer, string remarks, string description)
        {
            return logbookDB.CreateLogBook(date, chiefEngineer, remarks, description);
        }

        /// <summary>
        /// This method creates a log item.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="description"></param>
        /// <returns>boolean</returns>
        public bool CreateLogItem(string itemName, string unitOfMeasurement, string description)
        {
            return logbookDB.CreateLogItem(itemName, unitOfMeasurement, description, false);
        }

        /// <summary>
        /// this method updates a logbook.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="remarks"></param>
        /// <param name="chiefEngineer"></param>
        /// <returns>boolean</returns>
        public bool UpdateLogBook(DateTime date, string description, string remarks, string chiefEngineer)
        {
            bool success;

            try
            {
                success = logbookDB.UpdateLogBook(date, description, remarks, chiefEngineer);
            }

            catch (Exception)
            {
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method updates a log item.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="newName"></param>
        /// <param name="description"></param>
        /// <returns>boolean</returns>
        public bool UpdateLogItem(string itemName, string unitOfMeasurement, string newName, string description)
        {
            return logbookDB.UpdateLogItem(itemName, unitOfMeasurement, newName, description);
        }

        /// <summary>
        /// This method updates a log item reading.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="date"></param>
        /// <param name="todaysReading"></param>
        /// <returns>boolean</returns>
        public bool UpdateLogItemReading(string itemName, DateTime date, string todaysReading)
        {
            return logbookDB.UpdateLogItemReading(itemName, date, todaysReading);
        }

        /// <summary>
        /// This method find a logbook by date.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>logbook</returns>
        public LogBook FindLogBook(DateTime date)
        {
            return logbookDB.FindLogBook(date);
        }

        /// <summary>
        /// This method finds a log item by itemName.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>logItem</returns>
        public LogItem FindLogItem(string itemName)
        {
            return logbookDB.FindLogItem(itemName);
        }

        /// <summary>
        /// This method finds log item readings by date.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>logItemReadings</returns>
        public List<LogItemReading> FindLogItemReadings(DateTime date)
        {
            return logbookDB.FindLogItemReadings(date);
        }

        /// <summary>
        /// This method finds a log item reading by itemName and date.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="date"></param>
        /// <returns>logItemReading</returns>
        public LogItemReading FindLogItemReading(string itemName, DateTime date)
        {
            return logbookDB.FindLogItemReading(itemName, date);
        }

        /// <summary>
        /// This method finds log item readings by itemName.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>logItemReadings</returns>
        public List<LogItemReading> FindLogItemReadingsByItem(string itemName)
        {
            return logbookDB.FindLogItemReadingsByItem(itemName);
        }

        /// <summary>
        /// This method deletes a log item by itemName.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>boolean</returns>
        public bool DeleteLogItem(string itemName)
        {
            return logbookDB.DeleteLogItem(itemName);
        }

        /// <summary>
        /// This method check if some of the parts needs an inspection.
        /// </summary>
        public void CheckMaintenance()
        {
            List<Job> jobs = logbookDB.CheckMaintenance();
            if (jobs.Count > 0)
            {
                foreach (Job job in jobs)
                {
                    if (!jobCtr.ListAllJobs().Any(j => j.logItem == job.logItem && job.date == DateTime.Today))
                    {
                        jobCtr.CreateJob(job.title, job.description, job.note, job.nameOfEmployee, job.timeBetweenJobs, false, job.role, job.DBImage, job.subGroup, job.logItem, job.inDays, false);   
                    }
                }
            }
        }

        /// <summary>
        /// This method fills the database with logbooks and log items.
        /// </summary>
        /// <returns></returns>
        public bool FillDatabase()
        {
            return logbookDB.FillDatabase();
        }
    }
}