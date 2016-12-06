using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class MyTabPage and is a subclass to the class TabPage.
    /// </summary>
    public class MyTabPage : TabPage
    {
        private Form form;

        /// <summary>
        /// This is the constructor for the class MyTabPage.
        /// </summary>
        /// <param name="form"></param>
        public MyTabPage(MyFormPage form)
        {
            this.form = form;
            this.Controls.Add(form.panel);
            this.Text = form.Text;
        }
    }

    /// <summary>
    /// This is the class MyFormPage.
    /// </summary>
    public class MyFormPage : Form
    {
        public Panel panel;
    }
}