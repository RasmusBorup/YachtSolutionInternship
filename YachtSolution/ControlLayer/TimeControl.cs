using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;

namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class TimeControl.
    /// </summary>
    public sealed class TimeControl
    {
        private static object syncRoot = new Object();
        private static volatile TimeControl instance;
        private TimeTableDB timetableDB;
        private EmployeeController employeeCtr;

        /// <summary>
        /// This is the constructor for the class TimeControl.
        /// </summary>
        private TimeControl()
        {
            timetableDB = TimeTableDB.GetInstance();
            employeeCtr = EmployeeController.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class TimeControl.
        /// </summary>
        /// <returns>_instance</returns>
        public static TimeControl GetInstance()
        {
            if(instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new TimeControl();
                    }
                }
            }
            
            return instance;
        }

        /// <summary>
        /// This method creates a timeTable.
        /// </summary>
        /// <param name="startOfWork"></param>
        /// <param name="endOfWork"></param>
        /// <param name="nameOfWorker"></param>
        /// <returns>boolean</returns>
        public bool createTimeTable(DateTime startOfWork, DateTime endOfWork,  string nameOfWorker)
        {
            return timetableDB.CreateTimeTable(startOfWork, endOfWork, nameOfWorker);
        }

        /// <summary>
        /// This method deletes a timeTable.
        /// </summary>
        /// <param name="deleteID"></param>
        /// <returns>boolean</returns>
        public bool deleteTimeTable(int deleteID)
        {
            return timetableDB.DeleteTimeTable(deleteID);
        }

        /// <summary>
        /// This method updates a timeTable.
        /// </summary>
        /// <param name="startOfWork"></param>
        /// <param name="endOfWork"></param>
        /// <param name="presence"></param>
        /// <param name="nameOfWorker"></param>
        /// <param name="shftID"></param>
        /// <returns>boolean</returns>
        public bool updateTimeTable(DateTime startOfWork, DateTime endOfWork, String presence, string nameOfWorker, int shftID)
        {
            return timetableDB.UpdateTimeTable(shftID, startOfWork, endOfWork, presence, nameOfWorker);
        }

        /// <summary>
        /// This method finds timeTables by date.
        /// </summary>
        /// <param name="dateSearch"></param>
        /// <returns>timetables</returns>
        public List<TimeTable> findShiftsByDate(DateTime dateSearch)
        {
            return timetableDB.findTimeByDate(dateSearch);
        }

        /// <summary>
        /// This method finds timeTables by employee.
        /// </summary>
        /// <param name="employeeSearch"></param>
        /// <returns>timetables</returns>
        public List<TimeTable> findShiftsByEmployee(string employeeSearch)
        {
            return timetableDB.FindTimeTableByEmployeeName(employeeSearch);
        }

        /// <summary>
        /// This method a timeTable by shiftID.
        /// </summary>
        /// <param name="shiftIDSearch"></param>
        /// <returns>timetable</returns>
        public TimeTable findSingleShift(int shiftIDSearch)
        {
            return timetableDB.FindTimeTableByShiftID(shiftIDSearch);
        }

        /// <summary>
        /// This method adds a comment on a timeTable.
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="shiftIdSearch"></param>
        /// <returns>boolean</returns>
        public bool commentOnPresence(string comment, int shiftIdSearch)
        {
            return timetableDB.addComent(comment, shiftIdSearch);
        }

        /// <summary>
        /// This method returns all the timetables.
        /// </summary>
        /// <returns>timetables</returns>
        public List<TimeTable> getShifts()
        {
            return timetableDB.ListAllTimeTables();
        }

        /// <summary>
        /// This method returns all the employees.
        /// </summary>
        /// <returns>employees</returns>
        public List<Employee> GetEmployees()
        {
            return employeeCtr.ListAllEmployees();
        }
    }
}