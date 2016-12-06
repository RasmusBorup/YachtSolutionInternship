using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class ImageDB.
    /// </summary>
    public sealed class ImageDB
    {
        private static volatile ImageDB instance = null;
        private static object syncRoot = new Object();
        private DatabaseTableDataContext db;

        /// <summary>
        /// This is the constructor for the class ImageDB.
        /// </summary>
        private ImageDB()
        {
            this.db = new DatabaseTableDataContext();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class ImageDB.
        /// </summary>
        /// <returns>instance</returns>
        public static ImageDB GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ImageDB();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// This method returns a path where the image lies on the computer.
        /// </summary>
        /// <returns>imgLoc</returns>
        public string BrowseImage()
        {
            string imgLoc = "";

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = @"JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName;
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't browse the image.");
                Console.WriteLine("Error: " + exception.Message);
            }

            return imgLoc;
        }

        /// <summary>
        /// This method scale and saves an image in the database.
        /// </summary>
        /// <param name="imageLocation"></param>
        /// <returns>images</returns>
        public DBImage InsertImage(string imageLocation)
        {
            
            DBImage dbImage = null;
            ImageFormat format = ImageFormat.Jpeg;
            string saveLocation = AppDomain.CurrentDomain.BaseDirectory + "scaledDown.Jpeg";
            FileInfo f = new FileInfo(imageLocation);

            if (f.Length < 5000000)
            {
                var image = Image.FromFile(imageLocation);
                var newImage = ScaleImage(image, 200, 200);
                newImage.Save(saveLocation, format);

                DBImage imgToInsert = new DBImage();
                byte[] img = null;

                try
                {
                    FileStream fs = new FileStream(saveLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    if (!db.DBImages.Any(i => i.Image == img))
                    {
                        imgToInsert.Image = img;
                        db.DBImages.InsertOnSubmit(imgToInsert);
                        db.SubmitChanges();
                        dbImage = db.DBImages.ToList().Last();
                    }

                    else
                    {
                        dbImage = db.DBImages.ToList().First(i => i.Image == img);
                    }
                }

                catch (Exception exception)
                {
                    Console.WriteLine("Couldn't save the image in the database.");
                    Console.WriteLine("Error: " + exception.Message);
                    dbImage = null;
                }
            }

            return dbImage;
        }

        /// <summary>
        /// This method finds and returns an image from the database by its instance variable ImageID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>foundImage</returns>
        public Image SearchImageById(int? id)
        {
            Image image;
            int? imageId = id;

            try
            {
                var query = (from x in db.DBImages where x.ImageID == imageId select x).First();
                MemoryStream ms = new MemoryStream(query.Image.ToArray());
                Image foundImage = Image.FromStream(ms);
                image = foundImage;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't find the image by id.");
                Console.WriteLine("Error: " + exception.Message);
                image = null;
            }

            return image;
        }

        /// <summary>
        /// This method scales the image to the given size.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="maxWidth"></param>
        /// <param name="maxHeight"></param>
        /// <returns>newImage</returns>
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            try
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

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't scale the image to the right size.");
                Console.WriteLine("Error: " + exception.Message);
                return null;
            }
        }

        /// <summary>
        /// This method deletes an image from the database by its instance variable ImageID.
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns>success</returns>
        public bool DeleteImageByImageId(int imageId)
        {
            bool success;

            try
            {
                DBImage images = (from x in db.DBImages where x.ImageID == imageId select x).First();

                db.DBImages.DeleteOnSubmit(images);
                db.SubmitChanges();
                success = true;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Could not delete the Image.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        /// <summary>
        /// This method gets all imageIDs from the database.
        /// </summary>
        /// <returns>int</returns>
        public List<int> GetAllImageIds()
        {
            List<int> images = new List<int>();

            try
            {
                images = (from x in db.DBImages select x.ImageID).ToList();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                images.Clear();
            }

            return images;
        }
    }
}