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
    /// This is the class EmployeeController.
    /// </summary>
    public sealed class EmployeeController
    {
        private static object syncRoot = new Object();
        private static volatile EmployeeController instance;
        private EmployeeDB employeeDB;
        private ImageController imageCtr;

        /// <summary>
        /// This is the constructor for the class EmployeeController.
        /// </summary>
        private EmployeeController()
        {
            employeeDB = EmployeeDB.GetInstance();
            imageCtr = ImageController.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class EmployeeController.
        /// </summary>
        /// <returns>instance</returns>
        public static EmployeeController GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeController();
                    }
                }
            }
            return instance;
        }

        /// <summary>
        /// This method returns all the employees.
        /// </summary>
        /// <returns>employees</returns>
        public List<Employee> ListAllEmployees()
        {
            return employeeDB.GetAllEmployees();
        }

        /// <summary>
        /// This method creates an employee.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="jobTitle"></param>
        /// <param name="jobMail"></param>
        /// <param name="jobPhone"></param>
        /// <param name="ssn"></param>
        /// <param name="salary"></param>
        /// <param name="photo"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns>success</returns>
        public bool CreateEmployee(string name, string jobTitle, string jobMail, string jobPhone, string ssn, double salary, DBImage photo, string userName, string passWord)
        {
            return employeeDB.CreateEmployee(name, jobTitle, jobMail, jobPhone, ssn, salary, photo, userName, passWord);
        }

        /// <summary>
        /// This method deletes an employee.
        /// </summary>
        /// <param name="deleteID"></param>
        /// <returns>success</returns>
        public bool DeleteEmployee(int deleteID)
        {
            return employeeDB.DeleteEmployee(deleteID);
        }

        /// <summary>
        /// This method updates an employee.
        /// </summary>
        /// <param name="idOfEmployee"></param>
        /// <param name="name"></param>
        /// <param name="jobTitle"></param>
        /// <param name="jobMail"></param>
        /// <param name="jobPhone"></param>
        /// <param name="SSN"></param>
        /// <param name="salary"></param>
        /// <param name="photo"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns>success</returns>
        public bool UpdateEmployeeByID(int idOfEmployee, string name, string jobTitle, string jobMail, string jobPhone, string SSN, double salary, DBImage photo, string userName, string passWord)
        {
            return employeeDB.UpdateEmployeeByID(idOfEmployee, name, jobTitle, jobMail, jobPhone, SSN, salary, photo, userName, passWord);
        }

        /// <summary>
        /// This method finds employees by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>employees</returns>
        public List<Employee> FindEmployeeByName(string name)
        {
            return employeeDB.FindEmployeeByName(name);
        }

        /// <summary>
        /// This method finds employee by ssn.
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns>employee</returns>
        public Employee FindEmployeeBySsn(string ssn)
        {
            return employeeDB.FindEmployeeBySSN(ssn);
        }

        /// <summary>
        /// This method finds employee by employeeId.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>employee</returns>
        public Employee FindEmployeeByID(int employeeId)
        {
            return employeeDB.FindEmployeeById(employeeId);
        }

        /// <summary>
        /// This method saves an image.
        /// </summary>
        /// <param name="imageLocation"></param>
        /// <returns>DBImage</returns>
        public DBImage InsertImage(string imageLocation)
        {
            return imageCtr.InsertImage(imageLocation);
        }

        /// <summary>
        /// This method returns a path where the image lies on the computer.
        /// </summary>
        /// <returns>imagePath</returns>
        public string BrowseImage()
        {
            return imageCtr.BrowseImage();
        }

        /// <summary>
        /// This method returns an image by its id.
        /// </summary>
        /// <param name="photo"></param>
        /// <returns>Image</returns>
        public Image GetImage(int? photo)
        {
            return imageCtr.SearchImageById(photo);
        }

        /// <summary>
        /// This method finds an employee by its userName and passWord.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>employee</returns>
        public Employee FindEmployeeByLogin(string userName, string password)
        {
            return employeeDB.FindEmployeeByLogin(userName, password);
        }
    }
}