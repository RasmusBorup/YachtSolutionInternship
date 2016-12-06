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
    public partial class ViewTimetable : Form
    {
        private TimeControl tCtrl = TimeControl.GetInstance();
        public ViewTimetable()
        {
            InitializeComponent();
        }

        private void ViewTimetable_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = tCtrl.getShifts();

        }

        private void Find_Click(object sender, EventArgs e)
        {
            DateTime start = timeSearch.Value;
            foundGrid.DataSource = tCtrl.findShiftsByDate(start);
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string nameS = nameSearch.Text;
            foundGrid.DataSource = tCtrl.findShiftsByEmployee(nameS);
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            DataGridViewRow row = dataGridView1.Rows[i];
            int idDelete = Int32.Parse(row.Cells[0].ToString());
            tCtrl.deleteTimeTable(idDelete);
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            int i = foundGrid.CurrentRow.Index;
            DataGridViewRow row = dataGridView1.Rows[i];
            int idDelete = Int32.Parse(row.Cells[0].ToString());
            tCtrl.deleteTimeTable(idDelete);
        }
    }
}
