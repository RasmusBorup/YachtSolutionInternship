using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class GuestDB.
    /// </summary>
    public sealed class GuestDB
    {
        private static volatile GuestDB instance = null;
        private static object syncRoot = new Object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class GuestDB.
        /// </summary>
        private GuestDB()
        {
            this.db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class GuestDB.
        /// </summary>
        /// <returns>instance</returns>
        public static GuestDB GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new GuestDB();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method creates an object of the class Guest and inserts it in the database.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="ssn"></param>
        /// <param name="email"></param>
        /// <param name="note"></param>
        /// <returns>success</returns>
        public bool CreateGuest(string name, DateTime birthday, string phone, string address, string ssn, string email, string note)
        {
            Guest guest = new Guest();
            bool success = false;

            try
            {
                if (FindGuestBySsn(ssn).Count < 1)
                {
                    guest.name = name;
                    guest.birthday = birthday;
                    guest.phonenumber = phone;
                    guest.guestAddress = address;
                    guest.ssn = ssn;
                    guest.email = email;
                    guest.note = note;

                    db.Guests.InsertOnSubmit(guest);

                    db.SubmitChanges();
                    success = true;
                }

                else
                {
                    success = UpdateGuestBySsn(ssn, name, birthday, phone, address, ssn, email, note);
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the guest.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method returns all the objects of the class Guest that lies in the database.
        /// </summary>
        /// <returns>guests</returns>
        public List<Guest> ListAllGuests()
        {
            List<Guest> guests = new List<Guest>();

            try
            {
                guests = (from g in db.Guests select g).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't list all the guests.");
                Console.WriteLine("Error: " + exception.Message);
                guests.Clear();
            }

            return guests;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Guest that lies in the database by its instance variable ssn.
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns>guests</returns>
        public List<Guest> FindGuestBySsn(string ssn)
        {
            List<Guest> guests = new List<Guest>();

            try
            {
                guests = (from g in db.Guests where g.ssn.Contains(ssn) select g).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the guests by ssn.");
                Console.WriteLine("Error: " + exception.Message);
                guests.Clear();
            }

            return guests;
        }
        /// <summary>
        /// This method finds and returns a list of objects of the class Guest that lies in the database by its instance variable name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>guests</returns>
        public List<Guest> FindGuestByName(string name)
        {
            List<Guest> guests = new List<Guest>();

            try
            {
                guests = (from g in db.Guests where g.name.Contains(name) select g).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the guests by name.");
                Console.WriteLine("Error: " + exception.Message);
                guests.Clear();
            }

            return guests;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Guest that lies in the database by its instance variable phonenumber.
        /// </summary>
        /// <param name="phone"></param>
        /// <returns>guests</returns>
        public List<Guest> FindGuestByPhone(string phone)
        {
            List<Guest> guests = new List<Guest>();

            try
            {
                guests = (from g in db.Guests where g.phonenumber.Contains(phone) select g).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the guests by phone.");
                Console.WriteLine("Error: " + exception.Message);
                guests.Clear();
            }

            return guests;
        }

        /// <summary>
        /// This method finds and returns a list of objects of the class Guest that lies in the database by its instance variable email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>guests</returns>
        public List<Guest> FindGuestByEmail(string email)
        {
            List<Guest> guests = new List<Guest>();

            try
            {
                guests = (from g in db.Guests where g.email.Contains(email) select g).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the guests by email.");
                Console.WriteLine("Error: " + exception.Message);
                guests.Clear();
            }

            return guests;
        }

        /// <summary>
        /// This method finds and updates an object of the class Guest in the database by its instance variable ssn.
        /// </summary>
        /// <param name="old_ssn"></param>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="ssn"></param>
        /// <param name="email"></param>
        /// <param name="note"></param>
        /// <returns>success</returns>
        public bool UpdateGuestBySsn(string old_ssn, string name, DateTime birthday, string phone, string address, string ssn, string email, string note)
        {
            bool success;
            Guest oldGuest;

            try
            {
                oldGuest = db.Guests.SingleOrDefault(g => g.ssn == old_ssn);
                oldGuest.name = name;
                oldGuest.birthday = birthday;
                oldGuest.phonenumber = phone;
                oldGuest.guestAddress = address;
                oldGuest.email = email;
                oldGuest.note = note;

                db.SubmitChanges();

                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't update the guest.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method finds and deletes an object of the class Guest from the database by its instance variable ssn.
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns>success</returns>
        public bool DeleteGuest(string ssn)
        {
            bool success;

            try
            {
                Guest guest = (from g in db.Guests where g.ssn == ssn select g).First();

                db.Guests.DeleteOnSubmit(guest);
                db.SubmitChanges();

                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't delete the guest.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }
    }
}