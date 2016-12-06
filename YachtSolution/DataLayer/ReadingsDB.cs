using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class ReadingsDB.
    /// </summary>
    public sealed class ReadingsDB
    {
        private static volatile ReadingsDB instance = null;
        private static object syncRoot = new Object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class ReadingsDB.
        /// </summary>
        private ReadingsDB()
        {
            this.db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class ReadingsDB.
        /// </summary>
        /// <returns>instance</returns>
        public static ReadingsDB GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ReadingsDB();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method returns all the objects of the class Reading that lies in the database.
        /// </summary>
        /// <returns>readings</returns>
        public List<Reading> GetAllReadings()
        {
            List<Reading> readings;

            try
            {
                readings = (from x in db.Readings select x).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the readings.");
                Console.WriteLine("error: " + exception.Message);
                readings = new List<Reading>();
            }

            return readings;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Reading that lies in the database by its instance variable name.
        /// </summary>
        /// <param name="machineName"></param>
        /// <returns>readings</returns>
        public List<Reading> FindReadingByMachineName(string machineName)
        {
            List<Reading> readings;

            try
            {
                readings = (from s in db.Readings where s.machineName.Contains(machineName) select s).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the readings by machine name.");
                Console.WriteLine("error: " + exception.Message);
                readings = new List<Reading>();
            }

            return readings;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Reading that lies in the database by its instance variable MachineUsedFor.
        /// </summary>
        /// <param name="machineUsedFor"></param>
        /// <returns>readings</returns>
        public List<Reading> FindReadingByMachineUsedFor(string machineUsedFor)
        {
            List<Reading> readings;

            try
            {
                readings = (from s in db.Readings where s.MachineUsedFor.Contains(machineUsedFor) select s).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find all the readings by machine used for.");
                Console.WriteLine("Error message:" + exception.Message);
                readings = new List<Reading>();
                }

            return readings;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Reading that lies in the database by its instance variable servicedBy.
        /// </summary>
        /// <param name="servicedBy"></param>
        /// <returns>readings</returns>
        public List<Reading> FindReadingByServicedBy(string servicedBy)
        {
            List<Reading> readings;

            try
            {
                readings = (from s in db.Readings where s.servicedBy.Contains(servicedBy) select s).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the readings by service by.");
                Console.WriteLine("Error: " + exception.Message);
                readings = new List<Reading>();
            }

            return readings;
        }

        /// <summary>
        /// This method creates an object of the class Reading and inserts it in the database.
        /// </summary>
        /// <param name="machineName"></param>
        /// <param name="newValue"></param>
        /// <param name="servicedBy"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="machineUsedFor"></param>
        /// <param name="hourCounter"></param>
        /// <param name="maintainAtHours"></param>
        /// <returns>success</returns>
        public bool InsertReading(string machineName, double newValue, string servicedBy,string unitOfMeasurement, string machineUsedFor, int hourCounter, int maintainAtHours)
        {
            bool success;
            Reading reading = new Reading();

            try
            {
                reading.machineName = machineName;
                reading.newValue = newValue;
                reading.timeStamp = DateTime.Now;
                reading.servicedBy = servicedBy;
                reading.OldTimeStamp = DateTime.Now;
                reading.oldValue = 0;
                reading.MachineUsedFor = machineUsedFor;
                reading.UnitOfMeasurement = unitOfMeasurement;
                reading.hourCounter = hourCounter;
                reading.maintainAtHours = maintainAtHours;

                db.Readings.InsertOnSubmit(reading);
                db.SubmitChanges();
                success = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the reading.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes an object of the class Reading that lies in the database by its instance variable readId.
        /// </summary>
        /// <param name="readId"></param>
        /// <returns>boolean</returns>
        public bool DeleteReadingByReadId(int readId)
        {
            bool success;
            Reading reading;

            try
            {
                reading = (from x in db.Readings where x.readId == readId select x).First();

                db.Readings.DeleteOnSubmit(reading);
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't delete the reading.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and updates an object of the class Reading that lies in the database by its instance variable readId.
        /// </summary>
        /// <param name="readId"></param>
        /// <param name="machineName"></param>
        /// <param name="newValue"></param>
        /// <param name="oldValue"></param>
        /// <param name="servicedBy"></param>
        /// <param name="oldTimeStamp"></param>
        /// <param name="timeStamp"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="machineUsedFor"></param>
        /// <returns>boolean</returns>
        public bool UpdateReadingByReadId(int readId, string machineName, double newValue, double oldValue, string servicedBy, DateTime oldTimeStamp, DateTime timeStamp, string unitOfMeasurement, string machineUsedFor, int hourCounter, int maintainAtHours)
        {
            bool success;
            Reading reading = new Reading();
            try
            {
                Reading oldReading = db.Readings.SingleOrDefault(i => i.readId == readId);
                oldReading.machineName = machineName;
                oldReading.oldValue = oldReading.newValue;
                oldReading.servicedBy = servicedBy;
                oldReading.OldTimeStamp = oldReading.timeStamp;
                oldReading.timeStamp = timeStamp;
                oldReading.newValue = newValue;
                oldReading.UnitOfMeasurement = unitOfMeasurement;
                oldReading.MachineUsedFor = machineUsedFor;
                oldReading.hourCounter = hourCounter;
                oldReading.maintainAtHours = maintainAtHours;
                oldReading.difference = oldReading.newValue - oldReading.oldValue;

                

                db.SubmitChanges();

                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the reading.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }
    }
}