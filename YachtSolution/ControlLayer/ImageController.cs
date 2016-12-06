using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtSolution.DataLayer;

namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class ImageController.
    /// </summary>
    public sealed class ImageController
    {
        private static object _syncRoot = new Object();
        private static volatile ImageController _instance;
        private ImageDB imageDB;

        /// <summary>
        /// This is the constructor for the class ImageController.
        /// </summary>
        private ImageController()
        {
            imageDB = ImageDB.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class ImageController.
        /// </summary>
        /// <returns>instance</returns>
        public static ImageController GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new ImageController();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// This method returns a path where the image lies.
        /// </summary>
        /// <returns>imagePath</returns>
        public string BrowseImage()
        {
            return imageDB.BrowseImage();
        }

        /// <summary>
        /// This method saves an image in the database.
        /// </summary>
        /// <param name="imageLocation"></param>
        /// <returns>DBImage</returns>
        public DBImage InsertImage(string imageLocation)
        {
            return imageDB.InsertImage(imageLocation);
        }

        /// <summary>
        /// This method finds an image in the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Image</returns>
        public Image SearchImageById(int? id)
        {
            return imageDB.SearchImageById(id);
        }

        /// <summary>
        /// This method deletes an image by its id.
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns>boolean</returns>
        public bool DeleteImageById(int imageId)
        {
            return imageDB.DeleteImageByImageId(imageId);
        }

        /// <summary>
        /// this method returns all the ids on the images.
        /// </summary>
        /// <returns>integers</returns>
        public List<int> GetAllImageIds()
        {
            return imageDB.GetAllImageIds();
        }
    }
}