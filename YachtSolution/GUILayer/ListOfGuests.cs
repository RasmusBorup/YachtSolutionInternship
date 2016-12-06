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
    /// This is the class ListOfGuests and is a subclass to the class MyFormPage.
    /// </summary>
    public partial class ListOfGuests : MyFormPage
    {
        private GuestController guestCtr;

        /// <summary>
        /// this is the constructor for the class ListOfGuests.
        /// </summary>
        public ListOfGuests()
        {
            InitializeComponent();
            panel = panel1;
            this.guestCtr = GuestController.GetInstance();
            AddGuestToGridView(guestCtr.ListAllGuests());
        }

        /// <summary>
        /// This method call the FindGuests method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_button_Click(object sender, EventArgs e)
        {
            FindGuests();
        }

        /// <summary>
        /// This method call the RefreshList method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_button_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        /// <summary>
        /// This method refreshes the list Guests_dataGridView and the text boxes.
        /// </summary>
        public void RefreshList()
        {
            AddGuestToGridView(guestCtr.ListAllGuests());
            search_textBox.Clear();
        }

        /// <summary>
        /// This method opens the windows form create_guest.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createGuest_button_Click(object sender, EventArgs e)
        {
            Form create_guest = new CreateGuest(this);
            create_guest.Show();
        }

        /// <summary>
        /// This method opens the windows form update_guest and sends the selected guest to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateGuest_button_Click(object sender, EventArgs e)
        {
            Guest guestToUpdate = Guests_dataGridView.SelectedRows[0].DataBoundItem as Guest;
            Form update_guest = new UpdateGuest(guestToUpdate, this);
            update_guest.Show();
        }

        /// <summary>
        /// This method finds a list of objects of the class Guest.
        /// </summary>
        private void FindGuests()
        {
            List<Guest> guests = guestCtr.FindGuest(search_textBox.Text);
            AddGuestToGridView(guests);
        }

        /// <summary>
        /// This method adds a list of guests to the grid view Guests_dataGridView.
        /// </summary>
        /// <param name="guests"></param>
        private void AddGuestToGridView(List<Guest> guests)
        {
            Guests_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Guests_dataGridView.AutoGenerateColumns = true;
            Guests_dataGridView.DataSource = guests;
        }
    }
}