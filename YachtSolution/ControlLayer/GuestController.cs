using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;

namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class GuestController.
    /// </summary>
    public sealed class GuestController
    {
        private volatile static GuestController instance = null;
        private static object syncRoot = new Object();
        private GuestDB guestDB;

        /// <summary>
        /// This is the constructor for the class GuestController.
        /// </summary>
        private GuestController()
        {
            this.guestDB = GuestDB.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class GuestController.
        /// </summary>
        /// <returns>instance</returns>
        public static GuestController GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new GuestController();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method creates an guest.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="ssn"></param>
        /// <param name="email"></param>
        /// <param name="note"></param>
        /// <returns>boolean</returns>
        public bool CreateGuest(string name, DateTime birthday, string phone, string address, string ssn, string email, string note)
        {
            return guestDB.CreateGuest(name, birthday, phone, address, ssn, email, note);
        }

        /// <summary>
        /// This method returns all the guests.
        /// </summary>
        /// <returns>guests</returns>
        public List<Guest> ListAllGuests()
        {
            return guestDB.ListAllGuests();
        }

        /// <summary>
        /// This method finds Guest by ssn, name, phone or email.
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>guests</returns>
        public List<Guest> FindGuest(string searchString)
        {
            List<Guest> guests = new List<Guest>();

            guests = guestDB.FindGuestBySsn(searchString);

            if (guests.Count < 1)
            {
                guests = guestDB.FindGuestByName(searchString);
            }

            if (guests.Count < 1)
            {
                guests = guestDB.FindGuestByPhone(searchString);
            }

            if (guests.Count < 1)
            {
                guests = guestDB.FindGuestByEmail(searchString);
            }

            return guests;
        }

        /// <summary>
        /// This method updates a guest.
        /// </summary>
        /// <param name="old_ssn"></param>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="ssn"></param>
        /// <param name="email"></param>
        /// <param name="note"></param>
        /// <returns>boolean</returns>
        public bool UpdateGuest(string old_ssn, string name, DateTime birthday, string phone, string address, string ssn, string email, string note)
        {
            return guestDB.UpdateGuestBySsn(old_ssn, name, birthday, phone, address, ssn, email, note);
        }

        /// <summary>
        /// This method deletes a guest.
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns>boolean</returns>
        public bool DeleteGuest(string ssn)
        {
            return guestDB.DeleteGuest(ssn);
        }
    }
}