using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;

namespace YachtSolution.ControlLayer
{
	/// <summary>
	/// This is the class JobController.
	/// </summary>
	public sealed class JobController
	{
		private static object _syncRoot = new Object();
		private static volatile JobController _instance;
		private JobDB jobDB;
		private ImageController imageCtr;

		/// <summary>
		/// This is the constructor for the class JobController.
		/// </summary>
		private JobController()
		{
			jobDB = JobDB.GetInstance();
			imageCtr = ImageController.GetInstance();
		}

		/// <summary>
		/// This method is a multi threaded singleton for the class JobController.
		/// </summary>
		/// <returns>_instance</returns>
		public static JobController GetInstance()
		{
			if (_instance == null)
			{
				lock (_syncRoot)
				{
					if (_instance == null)
					{
                        _instance = new JobController();
					}
				}
			}

			return _instance;
		}

		/// <summary>
		/// This method returns a list of all the jobs.
		/// </summary>
		/// <returns>jobs</returns>
		public List<Job> ListAllJobs()
		{
			return jobDB.ListAllJobs();
		}

		/// <summary>
		/// This method creates a job.
		/// </summary>
		/// <param name="title"></param>
		/// <param name="description"></param>
		/// <param name="note"></param>
		/// <param name="nameOfWorker"></param>
		/// <param name="workerID"></param>
		/// <param name="timeBetweenJobs"></param>
		/// <param name="done"></param>
		/// <param name="role"></param>
		/// <param name="photo"></param>
		/// <param name="subGroup"></param>
		/// <returns>boolean</returns>
		public bool CreateJob(string title, string description, string note, string nameOfWorker, int timeBetweenJobs, bool done, string role, DBImage photo, string subGroup, string logItem, bool days, bool template)
		{
			return jobDB.CreateJob(title, description, nameOfWorker, timeBetweenJobs, done, note, role, false, photo, subGroup, logItem, days, template);
		}

		/// <summary>
		/// This method updates a job.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="title"></param>
		/// <param name="description"></param>
		/// <param name="workerID"></param>
		/// <param name="timeBetweenJobs"></param>
		/// <param name="done"></param>
		/// <param name="note"></param>
		/// <param name="role"></param>
		/// <param name="updateRoutine"></param>
		/// <param name="photo"></param>
		/// <param name="subGroup"></param>
		/// <returns>boolean</returns>
		public bool UpdateJob(int id, string title, string description, string nameOfEmloyee, int timeBetweenJobs, bool done, string note, string role, bool updateRoutine, DBImage photo, string subGroup, string logItem)
		{
			return jobDB.UpdateJob(id, title, description, nameOfEmloyee, timeBetweenJobs, done, note, role, updateRoutine, photo, subGroup, logItem);
		}

		/// <summary>
		/// This method deletes a job.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="deleteRoutine"></param>
		/// <returns>boolean</returns>
		public bool DeleteJob(int id, bool deleteRoutine)
		{
			return jobDB.DeleteJob(id, deleteRoutine);
		}

		/// <summary>
		/// This method checks if a job is a routine.
		/// </summary>
		/// <param name="id"></param>
		/// <returns>boolean</returns>
		public bool CheckIfRoutine(int id)
		{
			return jobDB.CheckIfRoutine(id);
		}

		/// <summary>
		/// This method checks the routine jobs.
		/// </summary>
		public bool CheckRoutines()
		{
			return jobDB.CheckRoutines();
		}

		/// <summary>
		/// This method finds an image in the database.
		/// </summary>
		/// <param name="id"></param>
		/// <returns>Image</returns>
		public Image GetImage(int? id)
		{
			return imageCtr.SearchImageById(id);
		}

		/// <summary>
		/// This method returns the path to an image.
		/// </summary>
		/// <returns>string</returns>
		public string BrowseImage()
		{
			return imageCtr.BrowseImage();
		}

		/// <summary>
		/// This method saves an image in the database.
		/// </summary>
		/// <param name="imageLocation"></param>
		/// <returns>DBImage</returns>
		public DBImage InsertImage(string imageLocation)
		{
			return imageCtr.InsertImage(imageLocation);
		}

		/// <summary>
		/// This method finds jobs by subgroup.
		/// </summary>
		/// <param name="search"></param>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns>jobs</returns>
		public List<Job> FindJobsBySubGroup(string name)
		{
			return jobDB.FindJobsBySubGroup(name);
		}

		/// <summary>
		/// This method creates a subgroup.
		/// </summary>
		/// <param name="name"></param>
		/// <returns>boolean</returns>
		public bool InsertSubGroup(string name)
		{
			return jobDB.InsertSubGroup(name);
		}

		/// <summary>
		/// This method gets all the subgroups.
		/// </summary>
		/// <returns>subgroups</returns>
		public List<SubGroup> GetAllSubGroups()
		{
			return jobDB.GetAllSubGroups();
		}

		/// <summary>
		/// This method finds a subgroup by its name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns>subgroup</returns>
		public SubGroup FindSubGroupByName(string name)
		{
			return jobDB.FindSubGroupByName(name);
		}

		/// <summary>
		/// This method updates a subgroup.
		/// </summary>
		/// <param name="oldName"></param>
		/// <param name="newName"></param>
		/// <returns>boolean</returns>
		public bool UpdateSubGroup(string oldName, string newName)
		{
			return jobDB.UpdateSubGroup(oldName, newName);
		}

		/// <summary>
		/// This method deletes a subgroup.
		/// </summary>
		/// <param name="name"></param>
		/// <returns>boolean</returns>
		public bool DeleteSubGroup(string name)
		{
			return jobDB.DeleteSubGroup(name);
		}

		/// <summary>
		/// This method finds jobs by its instance variables.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="role"></param>
		/// <param name="subGroup"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="roleName"></param>
		/// <param name="groupName"></param>
		/// <returns>jobs</returns>
		public List<Job> DynamicSearch(bool start, bool end, bool subGroup, DateTime startDate, DateTime endDate, string roleName, string groupName)
		{
			return jobDB.DynamicSeach(start, end, subGroup, startDate, endDate, roleName, groupName);
		}
	}
}