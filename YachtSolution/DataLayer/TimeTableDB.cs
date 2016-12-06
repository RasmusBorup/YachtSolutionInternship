using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class TimeTableDB.
    /// </summary>
    public sealed class TimeTableDB
    {
        private static volatile TimeTableDB instance = null;
        private static object syncRoot = new Object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class TimeTableDB.
        /// </summary>
        private TimeTableDB()
        {
            this.db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class TimeTableDB.
        /// </summary>
        /// <returns>instance</returns>
        public static TimeTableDB GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new TimeTableDB();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method creates an object of the class TimeTable and inserts it in the database.
        /// </summary>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <param name="employeeName"></param>
        /// <returns>success</returns>
        public bool CreateTimeTable(DateTime dateStart, DateTime dateEnd, string employeeName)
        {
            bool success;
            TimeTable timeTable = new TimeTable();

            try
            {
                timeTable.DateStart = dateStart;
                timeTable.DateEnd = dateEnd;
                
                timeTable.EmployeeName = employeeName;
                
                db.TimeTables.InsertOnSubmit(timeTable);
                db.SubmitChanges();

                success = true;
            }

            catch(Exception exception)
            {
                Console.WriteLine("Couldn't create the time table.");
                Console.WriteLine("error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method returns all the objects of the class TimeTable that lies in the database.
        /// </summary>
        /// <returns>timeTables</returns>
        public List<TimeTable> ListAllTimeTables()
        {
            List<TimeTable> timeTables = new List<TimeTable>();

            try
            {
                timeTables = (from tt in db.TimeTables select tt).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the time tables.");
                Console.WriteLine("error: " + exception.Message);
                timeTables.Clear();
            }

            return timeTables;
        }

        /// <summary>
        /// This method finds and returns an object of the class TimeTable that lies in the database by its instance variable ShiftID.
        /// </summary>
        /// <param name="shiftId"></param>
        /// <returns>timeTable</returns>
        public TimeTable FindTimeTableByShiftID(int shiftId)
        {
            TimeTable timeTable;

            try
            {
                timeTable = (from tt in db.TimeTables where tt.ShiftID == shiftId select tt).First();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the time table by shift id.");
                Console.WriteLine("error: " + exception.Message);
                timeTable = null;
            }

            return timeTable;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Employee that lies in the database by its instance variable EmployeeName.
        /// </summary>
        /// <param name="employeeName"></param>
        /// <returns>timeTable</returns>
        public List<TimeTable> FindTimeTableByEmployeeName(string employeeName)
        {
            List<TimeTable> timeTables = new List<TimeTable>();

            try
            {
                timeTables = (from tt in db.TimeTables where tt.EmployeeName.Contains(employeeName) select tt).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the time tables by employee name.");
                Console.WriteLine("error: " + exception.Message);
                timeTables.Clear();
            }

            return timeTables;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class TimeTable that lies in the database by its instance variable DateStart.
        /// </summary>
        /// <param name="searchTime"></param>
        /// <returns>timeTable</returns>
        public List<TimeTable> findTimeByDate(DateTime searchTime)
        {
            List<TimeTable> timeTables = new List<TimeTable>();

            try
            {
                timeTables = (from tt in db.TimeTables where tt.DateStart == searchTime select tt).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the time tables by date.");
                Console.WriteLine("error: " + exception.Message);
                timeTables.Clear();
            }

            return timeTables;
        }

        /// <summary>
        /// This method finds and updates an object of the class TimeTable that lies in the database by its instance variable ShiftID.
        /// </summary>
        /// <param name="shiftID"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <param name="presence"></param>
        /// <param name="employeeName"></param>
        /// <returns></returns>
        public bool UpdateTimeTable(int shiftID, DateTime dateStart, DateTime dateEnd, string presence, string employeeName)
        {
            bool success;
            TimeTable timeTable;

            try
            {
                timeTable = FindTimeTableByShiftID(shiftID);
                timeTable.DateStart = dateStart;
                timeTable.DateEnd = dateEnd;
                timeTable.Presence = presence;
                timeTable.EmployeeName = employeeName;

                db.SubmitChanges();

                success = true;
            }

            catch(Exception exception)
            {
                Console.WriteLine("Couldn't update the time table.");
                Console.WriteLine("error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes an object of the class TimeTable that lies in the database by its instance variable ShiftID.
        /// </summary>
        /// <param name="shiftID"></param>
        /// <returns>success</returns>
        public bool DeleteTimeTable(int shiftID)
        {
            bool success;
            TimeTable timeTable;

            try
            {
                timeTable = (from tt in db.TimeTables where tt.ShiftID == shiftID select tt).First();
                db.TimeTables.DeleteOnSubmit(timeTable);
                db.SubmitChanges();
                success = true;
            }

            catch(Exception exception)
            {
                Console.WriteLine("Couldn't delete the time table.");
                Console.WriteLine("error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method add a comment to an object of the class TimeTable that lies in the database.
        /// </summary>
        /// <param name="coment"></param>
        /// <param name="shiftID"></param>
        /// <returns>boolean</returns>
        public bool addComent(String coment, int shiftID)
        {
            bool success;
            TimeTable timeTable;

            try
            {
                timeTable = db.TimeTables.SingleOrDefault(tt => tt.ShiftID == shiftID);
                timeTable.Presence = coment;
                db.SubmitChanges();
                success = true;
            }

            catch(Exception exception)
            {
                Console.WriteLine("Couldn't add a comment to the timeTable.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }
    }
}