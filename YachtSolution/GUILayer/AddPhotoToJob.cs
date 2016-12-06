using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using YachtSolution.ControlLayer;

namespace YachtSolution.GUILayer
{
    public partial class AddPhotoToJob : Form
    {
        private JobController jCtr;

        public AddPhotoToJob()
        {
            InitializeComponent();
            this.jCtr = JobController.GetInstance();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();//Allows to browse after files.

            string filepath = openFileDialog1.FileName;
            txtBrowse.Text = filepath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filepath = openFileDialog1.FileName;

            if(txtBrowse.Text != "")
            {
                FileStream FS = new FileStream(filepath, FileMode.Open, FileAccess.Read);//Create a file stream object associated to user selected file.

                byte[] img = new byte[FS.Length];//Create a byte array with size of user selected file stream length.

                FS.Read(img, 0, Convert.ToInt32(FS.Length));//read user selected file stream in to byte array.

                MemoryStream ms = new MemoryStream(img);//Create a memory stream object associated to img.
                Image returnImage = Image.FromStream(ms);//Convert from stream to image.

                Image image = ScaleImage(returnImage, 338, 281);//Resize image to pictureBox size.

                //test 1
                byte[] imi = new byte[0];
                MemoryStream im = new MemoryStream();
                returnImage.Save(im, System.Drawing.Imaging.ImageFormat.Png);

                imi = im.ToArray();
                //
                //test 2
                BinaryReader br = new BinaryReader(FS);
                byte[] imo = br.ReadBytes((Int32)FS.Length);
                //

                try
                {
                    if (img != null)
                    {
                        //txtBrowse.Text = img.ToString();
                        txtBrowse.Text = br.ToString();

                        //jCtr.AddPhoto(img);
                        //jCtr.AddPhoto(imi);//Part off test 1
                        //jCtr.AddPhoto(imo);//Part off test 2
                    }

                    //txtBrowse.Text = "Photo saved";

                    pictureBox1.Image = image;
                }

                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
            }
            else
            {
                txtBrowse.Text = "You must browse for a photo";
            }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void btnGetPhoto_Click(object sender, EventArgs e)
        {
            byte[] img = jCtr.GetPhoto();

            txtBrowse.Text = jCtr.GetPhoto().ToString();

            MemoryStream ms = new MemoryStream(img);

            byte[] i = new byte[ms.Length];
            ms.Read(i, 0, Convert.ToInt32(ms.Length));

            BinaryReader br = new BinaryReader(ms);
            byte[] imo = br.ReadBytes((Int32)ms.Length);

            //ImageConverter imgCon = new ImageConverter();
            //(byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
            //Image inImg = (Image)imgCon.CanConvertTo(i, typeof(Image));

            //Image inImg = (Image)imgCon.ConvertFrom(i);

            //MemoryStream mi = new MemoryStream(i);
            //Image returnImage = Image.FromStream(ms);

            MemoryStream mimi = new MemoryStream(imo);
            Image reImg = Image.FromStream(mimi);

            txtBrowse.Text = ms.ToString();

            //Image image = ScaleImage(returnImage, 338, 281);
            //Image image = ScaleImage(inImg, 338, 281);
            Image image = ScaleImage(reImg, 338, 281);

            pictureBox1.Image = image;
        }
    }
}
