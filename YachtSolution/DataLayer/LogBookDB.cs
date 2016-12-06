using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class LogBookDB.
    /// </summary>
    public sealed class LogBookDB
    {
        private static LogBookDB instance;
        private static object syncRoot = new Object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class LogBookDB.
        /// </summary>
        private LogBookDB()
        {
            db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class LogBookDB.
        /// </summary>
        /// <returns>LogBookDB</returns>
        public static LogBookDB GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new LogBookDB();
                    }
                }
            }
            return instance;
        }

        /// <summary>
        /// This method creates an object of the class LogBook and inserts it in the database.
        /// </summary>
        /// <param name="chiefEngineer"></param>
        /// <param name="remarks"></param>
        /// <param name="description"></param>
        /// <returns>success</returns>
        public bool CreateLogBook(DateTime date, string chiefEngineer, string remarks, string description)
        {
            bool success;
            LogBook logBook = new LogBook();

            try
            {
                logBook.date = date;
                logBook.description = description;
                logBook.remarks = remarks;
                logBook.chiefEngineer = chiefEngineer;
                db.LogBooks.InsertOnSubmit(logBook);

                foreach (LogItem item in GetAllLogItems())
                {
                    CreateLogReading(item.logItem1, logBook.date, true);
                }

                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the logbook.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method creates an object of the class LogItem and inserts it in the database.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="description"></param>
        /// <param name="forUpdate"></param>
        /// <returns>boolean</returns>
        public bool CreateLogItem(string itemName, string unitOfMeasurement, string description, bool forUpdate)
        {
            bool success = CreateLogItemWithoutSubmit(itemName, unitOfMeasurement, description, forUpdate);
            db.SubmitChanges();
            return success;
        }

        /// <summary>
        /// This method creates a log item without saving it on the database.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="description"></param>
        /// <param name="forUpdate"></param>
        /// <returns>success</returns>
        private bool CreateLogItemWithoutSubmit(string itemName, string unitOfMeasurement, string description, bool forUpdate)
        {
            bool success;
            LogItem logItem = new LogItem();

            logItem.logItem1 = itemName;
            logItem.unitOfMeasurement = unitOfMeasurement;
            logItem.description = description;

            try
            {
                db.LogItems.InsertOnSubmit(logItem);

                if (!forUpdate)
                {
                    foreach (LogBook logBook in GetAllLogBooks())
                    {
                        CreateLogReading(logItem.logItem1, logBook.date, false);
                    }
                }

                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the log item.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method creates an object of the class LogItemReading and inserts it in the database.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="date"></param>
        /// <returns>success</returns>
        private bool CreateLogReading(string itemName, DateTime date, bool singleCreate)
        {
            bool success;
            LogItemReading reading = new LogItemReading();

            reading.logItem = itemName;
            reading.date = date;
            reading.todaysReading = 0;

            if (singleCreate)
            {
                if (FindLogItemReading(itemName, date.AddDays(-1)) != null)
                {
                    reading.yesterdaysReading = FindLogItemReading(itemName, date.AddDays(-1)).todaysReading;
                }

                else
                {
                    reading.yesterdaysReading = 0;
                }
            }

            reading.difference = reading.todaysReading - reading.yesterdaysReading;

            try
            {
                db.LogItemReadings.InsertOnSubmit(reading);
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the log item reading.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method returns all the objects of the class LogBook that lies in the database.
        /// </summary>
        /// <returns>List<LogBook></returns>
        public List<LogBook> GetAllLogBooks()
        {
            List<LogBook> logBooks = new List<LogBook>();

            try
            {
                logBooks = db.LogBooks.ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the logbooks.");
                Console.WriteLine("Error: " + exception.Message);
                logBooks = new List<LogBook>();
            }

            return logBooks;
        }

        /// <summary>
        /// This method returns all the objects of the class LogItem that lies in the database.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>logItems</returns>
        public List<LogItem> GetAllLogItems()
        {
            List<LogItem> logItems = new List<LogItem>();

            try
            {
                logItems = db.LogItems.ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the log items.");
                Console.WriteLine("Error: " + exception.Message);
            }

            return logItems;
        }

        /// <summary>
        /// This method returns all the objects of the class LogItemReading that lies in the database.
        /// </summary>
        /// <returns>logItemReadings</returns>
        public List<LogItemReading> GetAllLogReadings()
        {
            List<LogItemReading> readings = new List<LogItemReading>();

            try
            {
                readings = db.LogItemReadings.ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the log item readings.");
                Console.WriteLine("Error: " + exception.Message);
            }

            return readings;
        }

        /// <summary>
        /// This method finds and returns an object of the class LogBook that lies in the database by its instance variable date.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>logbook</returns>
        public LogBook FindLogBook(DateTime date)
        {
            LogBook logbook;

            try
            {
                logbook = GetAllLogBooks().SingleOrDefault(l => l.date == date);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the logbooks by date.");
                Console.WriteLine("Error: " + exception.Message);
                logbook = null;
            }

            return logbook;
        }

        /// <summary>
        /// This method finds and returns an object of the class LogItem that lies in the database by its instance variable logItem1.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>logItem</returns>
        public LogItem FindLogItem(string itemName)
        {
            LogItem logItem;

            try
            {
                logItem = GetAllLogItems().SingleOrDefault(l => l.logItem1 == itemName);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the log items by item name.");
                Console.WriteLine("Error: " + exception.Message);
                logItem = null;
            }

            return logItem;
        }

        /// <summary>
        /// This method finds and returns an object of the class LogItemReading that lies in the database by its instance variable logItem and date.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="date"></param>
        /// <returns>logItemReading</returns>
        public LogItemReading FindLogItemReading(string itemName, DateTime date)
        {
            LogItemReading logItemReading;

            try
            {
                logItemReading = GetAllLogReadings().Single(r => r.logItem == itemName && r.date == date.Date);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the log item reading by date and item name.");
                Console.WriteLine("Error: " + exception.Message);
                logItemReading = null;
            }

            return logItemReading;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class LogItemReading that lies in the database by its instance variable date.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>logItemReadings</returns>
        public List<LogItemReading> FindLogItemReadings(DateTime date)
        {
            List<LogItemReading> logItemReadings;

            try
            {
                logItemReadings = GetAllLogReadings().Where(r => r.date == date.Date).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the log item readings by date.");
                Console.WriteLine("Error: " + exception.Message);
                logItemReadings = new List<LogItemReading>();
            }

            return logItemReadings;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class LogItemReading that lies in the database by its instance variable logItem.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>logItemReadings</returns>
        public List<LogItemReading> FindLogItemReadingsByItem(string itemName)
        {
            List<LogItemReading> logItemReadings;

            try
            {
                logItemReadings = GetAllLogReadings().Where(r => r.logItem == itemName).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the log item readings by item name.");
                Console.WriteLine("Error: " + exception.Message);
                logItemReadings = new List<LogItemReading>();
            }

            return logItemReadings;
        }

        /// <summary>
        /// This method finds and updates an object of the class LogBook that lies in the database by its instance variable date.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="remarks"></param>
        /// <param name="chiefEngineer"></param>
        /// <returns>success</returns>
        public bool UpdateLogBook(DateTime date, string description, string remarks, string chiefEngineer)
        {
            LogBook logBookToUpdate = new LogBook();
            bool success;

            try
            {
                logBookToUpdate = FindLogBook(date);
                logBookToUpdate.description = description;
                logBookToUpdate.remarks = remarks;
                logBookToUpdate.chiefEngineer = chiefEngineer;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the instance variables in the logbook.");
                Console.WriteLine("Error: " + exception.Message);
                return false;
            }

            try
            {
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the logbook in the database.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and updates an object of the class LogItem that lies in the database by its instance variable itemName.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="newName"></param>
        /// <param name="description"></param>
        /// <returns>success</returns>
        public bool UpdateLogItem(string itemName, string unitOfMeasurement, string newName, string description)
        {
            bool success = false;
            LogItem itemToUpdate = new LogItem();

            try
            {
                itemToUpdate = FindLogItem(itemName);

                if (!itemName.Equals(newName))
                {
                    CreateLogItem(newName, unitOfMeasurement, description, true);
                    db.SubmitChanges();
                    itemToUpdate = FindLogItem(newName);

                    foreach (LogItemReading reading in GetAllLogReadings().Where(r => r.logItem == itemName))
                    {
                        reading.LogItem1 = itemToUpdate;
                    }

                    foreach (Job job in db.Jobs.Where(j => j.logItem == itemName))
                    {
                        job.LogItem1 = itemToUpdate;
                    }
                    DeleteLogItem(itemName);
                }

                itemToUpdate.unitOfMeasurement = unitOfMeasurement;
                itemToUpdate.description = description;
                db.SubmitChanges();
                success = true;

            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the log item.");
                Console.WriteLine("Error: " + exception.Message);
                DeleteLogItem(newName);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and updates an object of the class LogItemReading that lies in the database by its instance variable itemName.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="date"></param>
        /// <param name="todaysReading"></param>
        /// <returns>boolean</returns>
        public bool UpdateLogItemReading(string itemName, DateTime date, string todaysReading)
        {
            bool success;
            LogItemReading readingToUpdate = new LogItemReading();
            double todaysReadingD = 0;

            try
            {
                todaysReadingD = Convert.ToDouble(todaysReading);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't convert todaysReading to a double.");
                Console.WriteLine("Error: " + exception.Message);
            }

            try
            {
                readingToUpdate = FindLogItemReading(itemName, date);
                readingToUpdate.todaysReading = todaysReadingD;

                if (FindLogItemReading(itemName, date.AddDays(-1)) != null)
                {
                    readingToUpdate.yesterdaysReading = FindLogItemReading(itemName, date.AddDays(-1)).todaysReading;
                }

                else
                {
                    readingToUpdate.yesterdaysReading = 0;
                }

                readingToUpdate.difference = readingToUpdate.todaysReading - readingToUpdate.yesterdaysReading;
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the log item reading.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes an object of the class LogItemReading that lies in the database by its instance variable logItem.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>boolean</returns>
        public bool DeleteLogItem(string itemName)
        {
            bool success;
            List<LogItemReading> readings = FindLogItemReadingsByItem(itemName);
            LogItem item = FindLogItem(itemName);
            List<Job> jobs = db.Jobs.Where(j => j.logItem == itemName).ToList();//This was just a quick fix and does not follow the rules of our controller patern. It should be sent down from the controller!!!!

            try
            {
                db.LogItemReadings.DeleteAllOnSubmit(readings);
                db.SubmitChanges();
                db.Jobs.DeleteAllOnSubmit(jobs);
                db.SubmitChanges();
                db.LogItems.DeleteOnSubmit(item);
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't delete the log item.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method check if some of the parts needs an inspection.
        /// </summary>
        /// <returns>List<Job></returns>
        public List<Job> CheckMaintenance()
        {
            List<Job> maintenanceJobs = db.Jobs.Where(j => j.isTemplate).ToList();
            List<LogItemReading> readings = GetAllLogReadings().Where(r => r.date == DateTime.Today).ToList();
            List<Job> jobsToReturn = new List<Job>();

            foreach (Job job in maintenanceJobs)
            {
                LogItemReading reading = readings.Single(r => r.LogItem1 == job.LogItem1);
                double number = job.timeBetweenJobs - (reading.todaysReading % job.timeBetweenJobs);

                if (number < 30 && reading.todaysReading != 0)
                {
                    jobsToReturn.Add(job);
                }
            }

            return jobsToReturn;
        }

        /// <summary>
        /// This method saves logbooks and log items to the database that are created in the system.
        /// </summary>
        /// <returns></returns>
        public bool FillDatabase()
        {
            if (InsertLogbooks())
            {
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                    return false;
                }
            }
            if (InsertDefaultLogItems())
            {
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This method creates log items without saving them in the database.
        /// </summary>
        /// <returns>boolean</returns>
        private bool InsertDefaultLogItems()
        {
            try
            {
                if (FindLogItem("Generator 1 Oil Level") == null)
                {
                    CreateLogItem("Generator 1 Oil Level", "mm", "", false);
                }

                if (FindLogItem("Generator 1 Oil Preasure") == null)
                {
                    CreateLogItem("Generator 1 Oil Preasure", "Bar", "", false);
                }

                if (FindLogItem("Generator 1 Hour Count") == null)
                {
                    CreateLogItem("Generator 1 Hour Count", "Hours", "", false);
                }

                if (FindLogItem("Generator 1 Temperature") == null)
                {
                    CreateLogItem("Generator 1 Temperature", "C°", "", false);
                }

                if (FindLogItem("Generator 2 Oil Level") == null)
                {
                    CreateLogItem("Generator 2 Oil Level", "mm", "", false);
                }

                if (FindLogItem("Generator 2 Oil Preasure") == null)
                {
                    CreateLogItem("Generator 2 Oil Preasure", "Bar", "", false);
                }

                if (FindLogItem("Generator 2 Hour Count") == null)
                {
                    CreateLogItem("Generator 2 Hour Count", "Hours", "", false);
                }

                if (FindLogItem("Generator 2 Temperature") == null)
                {
                    CreateLogItem("Generator 2 Temperature", "C°", "", false);
                }

                if (FindLogItem("Water Level") == null)
                {
                    CreateLogItem("Water Level", "1/0", "Yes/No, 1 for yes 0 for no", false);
                }
            }

            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// this method creates and prepare it to be saved in the database.
        /// </summary>
        /// <returns></returns>
        private bool InsertLogbooks()
        {
            DateTime date = DateTime.Today.AddYears(-1);

            try
            {
                if (FindLogBook(date) == null)
                {
                    DateTime checkDate = DateTime.Today;
                    int i = 1;
                    List<LogBook> logs = GetAllLogBooks();

                    while (i < 1000 && checkDate != date)
                    {
                        checkDate = checkDate.AddDays(-1);

                        if (logs.SingleOrDefault(l => l.date == checkDate) == null)
                        {
                            LogBook log = new LogBook();
                            log.date = checkDate;
                            log.description = "";
                            log.remarks = "";
                            log.chiefEngineer = "";
                            db.LogBooks.InsertOnSubmit(log);
                        }
                        i++;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                return false;
            }
            return true;
        }
    }
}