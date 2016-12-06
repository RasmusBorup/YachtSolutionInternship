using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class EmployeeDB.
    /// </summary>
    public sealed class EmployeeDB
    {
        private static volatile EmployeeDB instance = null;
        private static object syncRoot = new Object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class EmployeeDB.
        /// </summary>
        private EmployeeDB()
        {
            this.db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class EmployeeDB.
        /// </summary>
        /// <returns>instance</returns>
        public static EmployeeDB GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeDB();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method creates an object of the class Employee and inserts it in the database.
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
            bool success;
            Employee employee = new Employee();

            try
            {
                employee.name = name;
                employee.salary = salary;
                employee.jobTitle = jobTitle;
                employee.jobEmail = jobMail;
                employee.jobPhone = jobPhone;
                employee.ssn = ssn;
                employee.userName = userName;
                employee.passWord = passWord;
                
                if (photo != null)
                {
                    employee.DBImage = db.DBImages.ToList().First(i => i.ImageID == photo.ImageID);
                }

                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the employee in the database.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes an object of the class Employee from the database by its instance variable idOfEmployee.
        /// </summary>
        /// <param name="deleteID"></param>
        /// <returns>success</returns>
        public bool DeleteEmployee(int deleteID)
        {
            bool success;
            Employee employee;

            try
            {
                employee = db.Employees.ToList().Find(e => e.idOfEmployee == deleteID);

                db.Employees.DeleteOnSubmit(employee);
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't delete the employee in the database.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and updates an object of the class Employee in the database by its instance variable idOfEmployee.
        /// </summary>
        /// <param name="idOfEmployee"></param>
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
        public bool UpdateEmployeeByID(int idOfEmployee, string name, string jobTitle, string jobMail, string jobPhone, string ssn, double salary, DBImage photo, string userName, string passWord)
        {
            bool success;
            Employee employee;

            try
            {
                employee = db.Employees.Single(e => e.idOfEmployee == idOfEmployee);
                employee.name = name;
                employee.jobTitle = jobTitle;
                employee.jobEmail = jobMail;
                employee.jobPhone = jobPhone;
                employee.ssn = ssn;
                employee.salary = salary;
                employee.userName = userName;
                employee.passWord = passWord;

                if (photo != null)
                {
                    employee.DBImage = db.DBImages.ToList().First(i => i.ImageID == photo.ImageID);
                }

                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the employee in the database.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method returns all the objects of the class Employee that lies in the database.
        /// </summary>
        /// <returns>employees</returns>
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                employees = (from a in db.Employees select a).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("couldn't get all the employees.");
                Console.WriteLine("Error: " + exception.Message);
                employees.Clear();
            }

            return employees;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Employee that lies in the database by its instance variable name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>employees</returns>
        public List<Employee> FindEmployeeByName(string name)
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                employees = db.Employees.ToList().Where(e => e.name.Contains(name)).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("couldn't get the employees by name.");
                Console.WriteLine("Error: " + exception.Message);
                employees.Clear();
            }

            return employees;
        }

        /// <summary>
        /// This method finds and returns an object of the class Employee that lies in the database by its instance variable idOfEmployee.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>employee</returns>
        public Employee FindEmployeeById(int employeeId)
        {
            Employee employee;

            try
            {
                employee = db.Employees.ToList().Find(e => e.idOfEmployee == employeeId);
            }

            catch (Exception exception)
            {
                Console.WriteLine("couldn't get the employee by idOfEmployee.");
                Console.WriteLine("Error: " + exception.Message);
                employee = null;
            }

            return employee;
        }

        /// <summary>
        /// This method finds and returns an object of the class Employee that lies in the database by its instance variable ssn.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>employee</returns>
        public Employee FindEmployeeBySSN(string ssn)
        {
            Employee employee;

            try
            {
                employee = db.Employees.ToList().Find(e => e.ssn == ssn);
            }

            catch (Exception exception)
            {
                Console.WriteLine("couldn't get the employee by idOfEmployee.");
                Console.WriteLine("Error: " + exception.Message);
                employee = null;
            }

            return employee;
        }

        /// <summary>
        /// This method finds and returns an object of the class Employee that lies in the database by its instance variable userName and passWord.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>employee</returns>
        public Employee FindEmployeeByLogin(string userName, string password)
        {
            Employee employee;

            try
            {
                employee = db.Employees.SingleOrDefault(e => e.userName == userName && e.passWord == password);
            }

            catch (Exception exception)
            {
                Console.WriteLine("couldn't get the employee by idOfEmployee.");
                Console.WriteLine("Error: " + exception.Message);
                employee = null;
            }

            return employee;
        }
    }
}