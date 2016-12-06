using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;

namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class SubGroupController.
    /// </summary>
    public sealed class SubGroupController
    {
        private static object _syncRoot = new Object();
        private static volatile SubGroupController _instance;
        private SubGroupDB subGroupDB;

        /// <summary>
        /// This is the constructor for the class SubGroupController.
        /// </summary>
        private SubGroupController()
        {
            subGroupDB = SubGroupDB.getInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class SubGroupController.
        /// </summary>
        /// <returns>_instance</returns>
        public static SubGroupController GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new SubGroupController();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// This method crates a sub group.
        /// </summary>
        /// <param name="name"></param>
        public bool InsertSubGroup(string name)
        {
            return subGroupDB.InsertSubGroup(name);
        }

        /// <summary>
        /// This method deletes a sub group.
        /// </summary>
        /// <param name="grpID"></param>
        public bool DeleteSubGroup(int grpID)
        {
            return subGroupDB.DeleteSubGroup(grpID);
        }

        /// <summary>
        /// This method finds and returns a list of Groups by searching on its instance variable ID.
        /// </summary>
        /// <param name="grpID"></param>
        /// <returns>group</returns>
        public List<SubGroup> FindGroupByID(int grpID)
        {
            return subGroupDB.FindGroupByID(grpID);
        }

        /// <summary>
        /// This method returns a list of all the inventories.
        /// </summary>
        /// <returns>inventories</returns>
        public List<SubGroup> GetAllSubGroups()
        {
            return subGroupDB.GetAllSubGroups();
        }

        /// <summary>
        /// This method finds and returns a sub group by searching on its instance variable ID.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string</returns>
        public string FindSubGroupByName(string name)
        {
            return subGroupDB.FindSubGroupByName(name);
        }

        public bool UpdateSubGroup(string oldName, string newName)
        {
            return subGroupDB.UpdateSubGroup(oldName, newName);
        }
    }
}