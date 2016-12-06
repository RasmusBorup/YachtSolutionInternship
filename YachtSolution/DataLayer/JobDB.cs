using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class JobDB.
    /// </summary>
    public sealed class JobDB
    {
        private static volatile JobDB instance = null;
        private static object syncRoot = new Object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class JobDB.
        /// </summary>
        private JobDB()
        {
            this.db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class JobDB.
        /// </summary>
        /// <returns>instance</returns>
        public static JobDB GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new JobDB();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method creates an object of the class Job and inserts it in the database.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="nameOfEmployee"></param>
        /// <param name="timeBetweenJobs"></param>
        /// <param name="done"></param>
        /// <param name="note"></param>
        /// <param name="role"></param>
        /// <param name="routineCheck"></param>
        /// <param name="photo"></param>
        /// <param name="subGroup"></param>
        /// <returns>success</returns>
        public bool CreateJob(string title, string description, string nameOfEmployee, int timeBetweenJobs, bool done, string note, string role, bool routineCheck, DBImage photo, string subGroup, string logItem, bool days, bool template)
        {
            bool success;
            int jobId = 0;
            Job job = new Job();

            try
            {
                job.title = title;
                job.description = description;
                job.nameOfEmployee = nameOfEmployee;
                job.timeBetweenJobs = timeBetweenJobs;
                job.done = done;
                job.note = note;
                job.role = role;
                job.date = DateTime.Today.Date;

                if (logItem != "")
                {
                    job.LogItem1 = db.LogItems.Single(l => l.logItem1 == logItem);
                }

                else
                {
                    job.logItem = null;
                }

                if (photo != null)
                {
                    job.DBImage = db.DBImages.First(i => i.ImageID == photo.ImageID);
                }

                job.subGroup = subGroup;
                job.isTemplate = template;
                db.Jobs.InsertOnSubmit(job);

                db.SubmitChanges();
                jobId = job.id;
                job.routineId = jobId;
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the job.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            if (job.timeBetweenJobs > 0 && success && !routineCheck && days)
            {
                success = CreateRoutineJob(jobId, title, description, timeBetweenJobs, note, role, photo, subGroup);
            }

            if (!success)
            {
                try
                {
                    db.Jobs.DeleteOnSubmit(job);
                    db.SubmitChanges();
                }

                catch (Exception exception)
                {
                    Console.WriteLine("Couldn't delete the job");
                    Console.WriteLine("Error: " + exception);
                }
            }
            return success;
        }

        /// <summary>
        /// This method creates objects of the class job and inserts them in the database.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="nameOfWorker"></param>
        /// <param name="timeBetweenJobs"></param>
        /// <param name="note"></param>
        /// <param name="role"></param>
        /// <param name="photo"></param>
        /// <param name="subGroup"></param>
        /// <returns>success</returns>
        private bool CreateRoutineJob(int jobId, string title, string description, int timeBetweenJobs, string note, string role, DBImage photo, string subGroup)
        {
            bool success = false;
            Job job = new Job();
            List<Job> jobs = new List<Job>();

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    job = new Job();
                    job.title = title;
                    job.description = description;
                    job.nameOfEmployee = null;
                    job.timeBetweenJobs = timeBetweenJobs;
                    job.done = false;
                    job.note = note;
                    job.role = role;
                    job.routineId = jobId;
                    job.subGroup = subGroup;
                    double daysToAdd = (int)timeBetweenJobs * i;

                    job.date = DateTime.Today.AddDays(daysToAdd);

                    if (photo != null)
                    {
                        job.DBImage = db.DBImages.First(p => p.ImageID == photo.ImageID);
                    }

                    jobs.Add(job);
                }

                db.Jobs.InsertAllOnSubmit(jobs);
                success = true;
                db.SubmitChanges();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the routine jobs.");
                Console.WriteLine("Error: " + exception.Message);
                //var jobsToDelete = db.Jobs.Where(j => j.routineId == jobId);
            }

            return success;
        }

        /// <summary>
        /// This method returns all the objects of the class job that lies in the database.
        /// </summary>
        /// <returns>jobs</returns>
        public List<Job> ListAllJobs()
        {
            List<Job> jobs = new List<Job>();

            try
            {
                jobs = db.Jobs.Where(j => !j.isTemplate).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the jobs.");
                Console.WriteLine("Error: " + exception.Message);
                jobs.Clear();
            }

            return jobs.ToList<Job>();
        }

        /// <summary>
        /// This method finds and updates a job from the database by its instance variable id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="workerId"></param>
        /// <param name="timeBetweenJobs"></param>
        /// <param name="done"></param>
        /// <param name="note"></param>
        /// <param name="role"></param>
        /// <param name="updateRoutine"></param>
        /// <param name="photo"></param>
        /// <param name="subGroup"></param>
        /// <returns>success</returns>
        public bool UpdateJob(int id, string title, string description, string employeeName, int timeBetweenJobs, bool done, string note, string role, bool updateRoutine, DBImage photo, string subGroup, string logItem)
        {
            bool success;
            Job job;

            try
            {
                job = db.Jobs.SingleOrDefault(j => j.id == id);
                job.title = title;
                job.description = description;
                job.nameOfEmployee = employeeName;
                job.timeBetweenJobs = timeBetweenJobs;
                job.done = done;
                job.note = note;
                job.role = role;

                if (photo != null)
                {
                    job.DBImage = db.DBImages.ToList().First(i => i.ImageID == photo.ImageID);
                }

                job.subGroup = subGroup;

                if (job.LogItem1 != null)
                {
                    foreach (Job otherJob in db.Jobs.Where(j => j.logItem == job.logItem))
                    {
                        otherJob.LogItem1 = db.LogItems.Single(l => l.logItem1 == logItem);
                    }
                    job.logItem = logItem;
                }

                if (updateRoutine)
                {
                    var routineJobs = db.Jobs.Where(j => j.routineId == job.routineId);
                    foreach (Job oldJob in routineJobs)
                    {
                        oldJob.title = title;
                        oldJob.description = description;
                        oldJob.note = note;
                        oldJob.role = role;
                        oldJob.timeBetweenJobs = timeBetweenJobs;
                        if (photo != null)
                        {
                            oldJob.DBImage = db.DBImages.ToList().First(j => j.ImageID == photo.ImageID);
                        }
                        oldJob.subGroup = subGroup;
                    }

                    //Update future jobs to fit with a possible change in frequency of a routine job
                    routineJobs = routineJobs.Where(j => j.date >= DateTime.Today).OrderBy(j => j.date);
                    DateTime first = routineJobs.First().date;
                    int i = 0;

                    foreach (Job oldJob in routineJobs)
                    {
                        oldJob.date = first.AddDays(timeBetweenJobs * i);
                        i++;
                    }
                }

                db.SubmitChanges();

                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the job.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes an object of the class Job that lies in the database by its instance variable id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>success</returns>
        public bool DeleteJob(int id, bool deleteRoutine)
        {
            bool success;
            Job job;

            try
            {
                job = db.Jobs.First(c => c.id == id);
                db.Jobs.DeleteOnSubmit(job);

                if (deleteRoutine)
                {
                    DeleteRoutine(job);
                }

                if (!job.inDays)
                {
                    db.Jobs.DeleteAllOnSubmit(db.Jobs.Where(j => j.logItem == job.logItem));
                }

                db.SubmitChanges();

                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't delete the job.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes a list of objects of the class job that lies in the database by its instance variable routineId.
        /// </summary>
        /// <param name="routineJob"></param>
        /// <returns>success</returns>
        public bool DeleteRoutine(Job routineJob)
        {
            bool success;
            List<Job> jobs;

            try
            {
                jobs = (db.Jobs.Where(j => j.routineId == routineJob.routineId)).ToList();
                db.Jobs.DeleteAllOnSubmit(jobs);
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't delete the routine jobs.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method checks if an object of the class job is a routine job by its instance variable routineId.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>success</returns>
        public bool CheckIfRoutine(int id)
        {
            bool success;
            Job job;

            try
            {
                job = db.Jobs.SingleOrDefault(j => j.id == id);
                int amountOfJobs = ListAllJobs().Where(j => j.routineId == job.routineId).Count();

                if (amountOfJobs > 1)
                {
                    success = true;
                }

                else
                {
                    success = false;
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't check the job if it is routine.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method Checks the object of the class Job for routine jobs.
        /// </summary>
        /// <returns>success</returns>
        public bool CheckRoutines()
        {
            bool success;

            try
            {
                List<Job> routines = ListAllJobs().Where(j => j.timeBetweenJobs > 0 && j.inDays).ToList();

                while (routines.Count > 0)
                {
                    Job r = routines.First();
                    List<Job> jobsInRoutine = routines.Where(j => j.routineId == r.routineId).ToList();

                    jobsInRoutine = jobsInRoutine.Where(j => j.date >= DateTime.Today).OrderBy(d => d.date).ToList();
                    int futureJobs = jobsInRoutine.Count;
                    int i = 1;

                    while (futureJobs < 6)
                    {
                        CreateJob(r.title, r.description, r.nameOfEmployee, r.timeBetweenJobs, false, r.note, r.role, true, r.DBImage, r.subGroup, null, true, false);
                        Job newJob = ListAllJobs().Last();
                        newJob.routineId = r.routineId;
                        DateTime nextDate = new DateTime();

                        if (jobsInRoutine.Count() != 0)
                        {
                            nextDate = jobsInRoutine.Last().date;
                        }
                        else
                        {
                            nextDate = routines.Last(j => j.routineId == r.routineId).date;
                        }

                        int daysToAdd = i * newJob.timeBetweenJobs;
                        nextDate = nextDate.AddDays(daysToAdd);
                        newJob.date = nextDate;
                        newJob.workerID = null;
                        i++;

                        futureJobs = ListAllJobs().FindAll(j => j.routineId == r.routineId).FindAll(j => j.date >= DateTime.Today).Count;
                    }
                    routines = routines.Where(j => j.routineId != r.routineId).ToList();
                }

                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't check the routine jobs.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds a list of jobs by its id.
        /// </summary>
        /// <param name="search"></param>
        /// <returns>jobs</returns>
        public List<Job> FindJobsBySubGroup(string name)
        {
            List<Job> jobs = new List<Job>();

            try
            {
                jobs = db.Jobs.Where(j => j.subGroup == name).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("couldn't list the jobs by SubGroup.");
                Console.WriteLine("Error: " + exception.Message);
            }

            return jobs;
        }

        /// <summary>
        /// This method creates an object of the class SubGroup and inserts it in the database.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>success</returns>
        public bool InsertSubGroup(string name)
        {
            SubGroup grp = new SubGroup();
            bool success = false;

            if (FindSubGroupByName(name) == null)
            {
                try
                {
                    grp.name = name;

                    db.SubGroups.InsertOnSubmit(grp);
                    db.SubmitChanges();
                    success = true;
                }

                catch (Exception exception)
                {
                    Console.WriteLine("Couldn't create the subgroup.");
                    Console.WriteLine("error: " + exception.Message);
                    success = false;
                }
            }

            return success;
        }

        /// <summary>
        /// This method returns all the objects of the class SubGroup that lies in the database.
        /// </summary>
        /// <returns>subGroups</returns>
        public List<SubGroup> GetAllSubGroups()
        {
            List<SubGroup> subGroups = new List<SubGroup>();

            try
            {
                subGroups = db.SubGroups.ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the subgroups.");
                Console.WriteLine("error: " + exception.Message);
            }

            return subGroups;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class SubGroup that lies in the database by its instance variable name.
        /// </summary>
        /// <returns>subGroup</returns>
        public SubGroup FindSubGroupByName(string name)
        {
            try
            {
                return db.SubGroups.Single(s => s.name == name);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the subgroups by name.");
                Console.WriteLine("error: " + exception.Message);
                return null;
            }
        }

        /// <summary>
        /// This method finds and updates an object of the class SubGroup that lies in the database by its instance variable subGroup.
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <returns>success</returns>
        public bool UpdateSubGroup(string oldName, string newName)
        {
            bool success;

            try
            {
                SubGroup sg = db.SubGroups.Single(s => s.name == oldName);
                sg.name = newName;
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the subGroup.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes an object of the class SubGroup that lies in the database by its instance variable subGroup.
        /// </summary>
        /// <param name="grpID"></param>
        /// <returns>success</returns>
        public bool DeleteSubGroup(string name)
        {
            bool success;

            try
            {
                SubGroup sg = db.SubGroups.Single(s => s.name == name);

                db.SubGroups.DeleteOnSubmit(sg);
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't delete the subgroup.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and return a list of objects of the class Job that lies in the database by its instance variable role, date and/or subGroup.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="subGroup"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="roleName"></param>
        /// <param name="groupName"></param>
        /// <returns>jobs</returns>
        public List<Job> DynamicSeach(bool start, bool end, bool subGroup, DateTime startDate, DateTime endDate, string roleName, string groupName)
        {
            List<Job> jobs = ListAllJobs();

            try
            {
                if (roleName != "" && roleName != "Administrator")
                {
                    jobs = jobs.Where(j => j.role == roleName).ToList();
                }

                if (start)
                {
                    jobs = jobs.Where(j => j.date >= startDate).ToList();
                }

                if (end)
                {
                    jobs = jobs.Where(j => j.date <= endDate).ToList();
                }

                if (subGroup)
                {
                    jobs = jobs.Where(j => j.subGroup == groupName).ToList();
                }

                if (startDate == DateTime.Today)
                {
                    List<Job> jobsToAdd = ListAllJobs().Where(j =>j.date < DateTime.Today && j.role == roleName && j.done == false).ToList();

                    foreach (Job job in jobsToAdd)
                    {
                        jobs.Add(job);
                    }
                }
            }

            catch(Exception exception)
            {
                Console.WriteLine("Couldn't find the jobs.");
                Console.WriteLine("Error: " + exception.Message);
                jobs = ListAllJobs();
            }

            return jobs;
        }
    }
}