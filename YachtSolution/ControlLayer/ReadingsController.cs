using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;

namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class ReadingsController.
    /// </summary>
    public sealed class ReadingsController
    {
        private static object syncRoot = new Object();
        private static volatile ReadingsController instance;
        private ReadingsDB _readingsDB;

        /// <summary>
        /// This is the constructor for the class ReadingsController.
        /// </summary>
        private ReadingsController()
        {
            _readingsDB = ReadingsDB.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class ReadingsController.
        /// </summary>
        /// <returns>instance</returns>
        public static ReadingsController GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ReadingsController();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method creates a reading.
        /// </summary>
        /// <param name="machineName"></param>
        /// <param name="newValue"></param>
        /// <param name="servicedBy"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="machineUsedFor"></param>
        /// <returns>boolean</returns>
        public bool InsertReading(string machineName, double newValue, string servicedBy, string unitOfMeasurement, string machineUsedFor, int hourCounter, int maintainAtHours)
        {
            return _readingsDB.InsertReading(machineName, newValue, servicedBy, unitOfMeasurement, machineUsedFor, hourCounter, maintainAtHours);
        }

        /// <summary>
        /// This method gets all the readings.
        /// </summary>
        /// <returns>readings</returns>
        public List<Reading> GetAllReadings()
        {
            return _readingsDB.GetAllReadings();
        }

        /// <summary>
        /// This method finds a reading by machine name.
        /// </summary>
        /// <param name="machineName"></param>
        /// <returns>readings</returns>
        public List<Reading> FindReadingByMachineName(string machineName)
        {
            return _readingsDB.FindReadingByMachineName(machineName);
        }

        /// <summary>
        /// This method finds a reading by service by.
        /// </summary>
        /// <param name="servicedBy"></param>
        /// <returns>readings</returns>
        public List<Reading> FindReadingByServicedBy(string servicedBy)
        {
            return _readingsDB.FindReadingByServicedBy(servicedBy);
        }

        /// <summary>
        /// This method deletes a reading by id.
        /// </summary>
        /// <param name="readId"></param>
        /// <returns>boolean</returns>
        public bool DeleteReadingByReadId(int readId)
        {
            return _readingsDB.DeleteReadingByReadId(readId);
        }

        /// <summary>
        /// this method update a reading by id.
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
            return _readingsDB.UpdateReadingByReadId(readId, machineName, newValue, oldValue, servicedBy, oldTimeStamp, timeStamp, unitOfMeasurement, machineUsedFor, hourCounter, maintainAtHours);
        }
    }
}