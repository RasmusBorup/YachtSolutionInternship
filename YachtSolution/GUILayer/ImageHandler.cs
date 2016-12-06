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
    public partial class ImageHandler : Form
    {
        private ImageController imageCtrl = ImageController.GetInstance();
        public ImageHandler()
        {
            InitializeComponent();
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            pbImageBox.ImageLocation = imageCtrl.BrowseImage();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            imageCtrl.InsertImage(pbImageBox.ImageLocation);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            pbImageBox.Image = imageCtrl.SearchImageById(Convert.ToInt32(tbImageId.Text));

        }
    }
}
