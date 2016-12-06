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
using YachtSolution.DataLayer;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateGuest and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class UpdateGuest : Form
    {
        private GuestController guestCtr;
        private Guest guestToUpdate;
        private ListOfGuests list;

        /// <summary>
        /// This is the constructor for the class UpdateGuest.
        /// </summary>
        /// <param name="guestToUpdate"></param>
        public UpdateGuest(Guest guestToUpdate, ListOfGuests list)
        {
            InitializeComponent();
            this.guestCtr = GuestController.GetInstance();
            this.guestToUpdate = guestToUpdate;
            this.list = list;

            name_textBox.Text = guestToUpdate.name;
            birthday_dateTimePicker.Value = guestToUpdate.birthday;
            phone_textBox.Text = guestToUpdate.phonenumber;
            address_textBox.Text = guestToUpdate.guestAddress;
            email_textBox.Text = guestToUpdate.email;
            note_textBox.Text = guestToUpdate.note;
        }

        /// <summary>
        /// This method updates a guest.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_button_Click(object sender, EventArgs e)
        {
            bool filled = false;
            bool success = false;
            string message;
            string old_ssn = guestToUpdate.ssn;
            string name = name_textBox.Text;
            DateTime birthday = birthday_dateTimePicker.Value;
            string phone = phone_textBox.Text;
            string address = address_textBox.Text;
            string email = email_textBox.Text;
            string note = note_textBox.Text;

            if (note != "" && email != "" && address != "" && phone != "" && name != "")
            {
                filled = true;
                success = guestCtr.UpdateGuest(old_ssn, name, birthday, phone, address, guestToUpdate.ssn, email, note);
            }

            if (filled == false)
            {
                message = "Check all text boxes before saving.";
            }

            else
            {
                if (success == false)
                {
                    message = "The guest couldn't be saved.";
                }

                else
                {
                    MessageBox.Show("The guest is saved");
                    Close();
                    list.RefreshList();
                    return;
                }
            }

            MessageBox.Show(message);
        }

        /// <summary>
        /// This method deletes a guest.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to remove the guest from the system?", "Warning", MessageBoxButtons.YesNo);
            if(answer == DialogResult.Yes)
            { 
                guestCtr.DeleteGuest(guestToUpdate.ssn);
                list.RefreshList();
                Close();
            } 
        }

        /// <summary>
        /// This method closes the class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}