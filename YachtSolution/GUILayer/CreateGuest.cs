using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ControlLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateGuest and is a subclass to the class Form.
    /// </summary>
    public partial class CreateGuest : Form
    {
        private GuestController guestCtr;
        private ListOfGuests list;

        /// <summary>
        /// This is the constructor for the class CreateGuest.
        /// </summary>
        public CreateGuest(ListOfGuests list)
        {
            InitializeComponent();
            this.guestCtr = GuestController.GetInstance();
            this.list = list;
        }

        /// <summary>
        /// This method creates a guest.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_button_Click(object sender, EventArgs e)
        {
            if(ValidateInput() == true)
            {
                bool success;
                string message = "";
                string name = name_textBox.Text;
                DateTime birthday = birthday_dateTimePicker.Value;
                string phone = phone_textBox.Text;
                string address = address_textBox.Text;
                string ssn = ssn_textBox.Text;
                string email = email_textBox.Text;
                string note = note_textBox.Text;

                success = guestCtr.CreateGuest(name, birthday, phone, address, ssn, email, note);

                if (success == false)
                {
                    message = "The guest couldn't be saved.";
                }

                else
                {
                    message = "The guest is saved";
                    list.RefreshList();
                    Close();
                    return;
                }

                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// This method calls the Close method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method closes this windows form.
        /// </summary>
        private void BackToMaster()
        {
            this.Close();
        }

        /// <summary>
        /// This method shows a message box.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="filled"></param>
        /// <param name="success"></param>
        public void PopUpBox(string message, bool filled, bool success)
        {
            if (filled == true && success == true)
            {
                if (MessageBox.Show(message) == DialogResult.OK)
                {
                    BackToMaster();
                }
            }

            else
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// This method validates the information in the boxes.
        /// </summary>
        /// <returns>validating</returns>
        private bool ValidateInput()
        {
            bool validating = true;
            int parsedSsn;
            int parsedPhone;

            if (validating && ssn_textBox.Text.Length != 10)
            {
                MessageBox.Show("The ssn has to be 10 digits long.");
                validating = false;
            }

            if (validating && !int.TryParse(ssn_textBox.Text, out parsedSsn))
            {
                MessageBox.Show("The ssn is not a valid cpr.");
                validating = false;
            }

            if (validating && name_textBox.Text.Length < 1)
            {
                MessageBox.Show("there have to be a name.");
                validating = false;
            }

            if (validating && birthday_dateTimePicker.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("The guest have to be born first, before writing him/her in to the system.");
                validating = false;
            }

            if (validating && phone_textBox.Text.Length < 1)
            {
                MessageBox.Show("there have to be a phone number.");
                validating = false;
            }

            if (validating && !int.TryParse(phone_textBox.Text, out parsedPhone))
            {
                MessageBox.Show("The phone have to be in digits");
                validating = false;
            }

            if (validating && address_textBox.Text.Length < 1)
            {
                MessageBox.Show("there have to be a address.");
                validating = false;
            }

            if (validating)
            {
                try
                {
                    new System.Net.Mail.MailAddress(this.email_textBox.Text);
                }

                catch (ArgumentException)
                {
                    MessageBox.Show("there have to be an email.");
                    validating = false;
                }

                catch (FormatException)
                {
                    MessageBox.Show("The Email isn't valid.");
                    validating = false;
                }
            }

            return validating;
        }
    }
}