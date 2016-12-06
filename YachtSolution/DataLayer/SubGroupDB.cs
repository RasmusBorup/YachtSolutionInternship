using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class SubGroupDB.
    /// </summary>
    public sealed class SubGroupDB
    {
        private static volatile SubGroupDB instance = null;
        private static object syncRoot = new object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class SubGroupDB.
        /// </summary>
        private SubGroupDB()
        {
            this.db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class SubGroupDB.
        /// </summary>
        /// <returns></returns>
        public static SubGroupDB getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new SubGroupDB();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method creates a subgroup in the database.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>success</returns>
        public bool InsertSubGroup(string name)
        {
            SubGroup grp = new SubGroup();
            //var query = (from g in db.SubGroups where g.Name.ToLower() == name.ToLower() select g).First();
            string n = FindSubGroupByName(name);
            bool success = false;
            try
            {
                if(n == "")
                {
                    //grp.Name = name;

                    db.SubGroups.InsertOnSubmit(grp);
                    db.SubmitChanges();
                    success = true;
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Couldn't create the subgroup.");
                Console.WriteLine("error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method deletes a subgroup from the database.
        /// </summary>
        /// <param name="grpID"></param>
        /// <returns>success</returns>
        public bool DeleteSubGroup(int grpID)
        {
            bool success;
            try
            {
                //var query = (from g in db.SubGroups where g.ID == grpID select g).First();

                //db.SubGroups.DeleteOnSubmit(query);
                //db.SubmitChanges();
                success = true;
            }
            catch(Exception exception)
            {
                Console.WriteLine("Couldn't delete the subgroup.");
                Console.WriteLine("error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds a Group by its instance variable ID.
        /// </summary>
        /// <param name="grpID"></param>
        /// <returns>subGroups</returns>
        public List<SubGroup> FindGroupByID(int grpID)
        {
            List<SubGroup> subGroups = new List<SubGroup>();

            try
            {
                //subGroups = (from g in db.SubGroups where g.ID == grpID select g).ToList();
            }

            catch(Exception exception)
            {
                Console.WriteLine("Couldn't find the subgroup by id.");
                Console.WriteLine("error: " + exception.Message);
                subGroups.Clear();
            }

            return subGroups;
        }

        /// <summary>
        /// This method returns all the groups that lies in the database.
        /// </summary>
        /// <returns>subGroups</returns>
        public List<SubGroup> GetAllSubGroups()
        {
            List<SubGroup> subGroups = new List<SubGroup>();

            try
            {
                subGroups = (from s in db.SubGroups select s).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the subgroups.");
                Console.WriteLine("error: " + exception.Message);
                subGroups.Clear();
            }

            return subGroups;
        }

        public bool UpdateSubGroup(string oldName, string newName)
        {
            try
            {
                SubGroup sg = db.SubGroups.Single(s => s.Name == oldName);
                sg.Name = newName;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method finds a group by name in the database.
        /// </summary>
        /// <returns>query</returns>
        public string FindSubGroupByName(string name)
        {
            try
            {
                //var query = (from g in db.SubGroups where g.Name.ToLower() == name.ToLower() select g).SingleOrDefault();
                //if (query != null)
                //{
                //    return query.ToString();
                //}
                //else
                //{
                    return "";
                //}
            }
            catch(Exception exception)
            {
                Console.WriteLine("Couldn't find the subgroups by name.");
                Console.WriteLine("error: " + exception.Message);
                return "";
            }
        }
    }
}