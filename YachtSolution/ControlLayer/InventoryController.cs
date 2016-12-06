using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.DataLayer;
using YachtSolution.ModelLayer;


namespace YachtSolution.ControlLayer
{
    /// <summary>
    /// This is the class InventoryController.
    /// </summary>
    public sealed class InventoryController
    {
        private static object _syncRoot = new Object();
        private static volatile InventoryController _instance;
        private InventoryDB inventoryDB;
        private ImageController imageCtr;

        /// <summary>
        /// This is the constructor for the class InventoryController.
        /// </summary>
        private InventoryController()
        {
            inventoryDB = new InventoryDB();
            imageCtr = ImageController.GetInstance();
        }

        /// <summary>
        /// This method is a multi threaded singleton for the class InventoryController.
        /// </summary>
        /// <returns>_instance</returns>
        public static InventoryController GetInstance()
        {
            if(_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new InventoryController();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// This method creates an inventory.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <param name="location"></param>
        /// <param name="manufacturer"></param>
        /// <param name="minimumAmount"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="serialNr"></param>
        /// <param name="photo"></param>
        /// <param name="partFor"></param>
        /// <param name="suppliers"></param>
        /// <returns>success</returns>
        public bool InsertItem(string name, int amount, string description, double price, int minimumAmount, string location, string manufacturer, string serialNo, string partFor, string suppliers, string role)
        {
            return inventoryDB.InsertItem(name, amount, description, price, minimumAmount, location, manufacturer, serialNo, partFor, suppliers, role);
        }

        /// <summary>
        /// This method returns all the inventories.
        /// </summary>
        /// <returns>inventories</returns>
        public List<InventoryItem> GetAllInventories()
        {
            return inventoryDB.GetAllInventories();
        }

        public List<Inventory> GetInventoriesByRole(string role)
        {
            return null; //inventoryDB.GetInventoriesByRole(role);
        }

        /// <summary>
        /// This method finds inventories by its name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>inventories</returns>
        public List<Inventory> FindItemByName(string name)
        {
            return null; //inventoryDB.FindItemByName(name);
        }

        /// <summary>
        /// This method finds inventories by its serial.
        /// </summary>
        /// <param name="serial"></param>
        /// <returns>inventories</returns>
        public List<Inventory> FindItemBySerialNr(string serial)
        {
            return null; //inventoryDB.FindItemBySerial(serial);
        }

        /// <summary>
        /// This method deletes a inventory.
        /// </summary>
        /// <param name="serialNr"></param>
        /// <returns>success</returns>
        public bool DeleteItemBySerialNr(string serialNr)
        {
            return false; //inventoryDB.DeleteItem(serialNr);
        }

        /// <summary>
        /// This method updates a inventory.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <param name="location"></param>
        /// <param name="manufacturer"></param>
        /// <param name="minimumAmount"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="serialNr"></param>
        /// <param name="photo"></param>
        /// <param name="partFor"></param>
        /// <param name="suppliers"></param>
        /// <returns>boolean</returns>
        public bool UpdateItemBySerialNr(string description, int amount, string location, string manufacturer,
            int minimumAmount, string name, double price, string serialNr, DBImage photo, string partFor, string suppliers)
        {
            return false; //inventoryDB.UpdateItemBySerial(description, amount, location, manufacturer, minimumAmount, name, price, serialNr, photo, partFor, suppliers);
        }

        /// <summary>
        /// This method finds an image.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Image</returns>
        public Image GetImage(int? id)
        {
            return imageCtr.SearchImageById(id);
        }

        /// <summary>
        /// This method returns the path to an image.
        /// </summary>
        /// <returns>imagePath</returns>
        public string BrowseImage()
        {
            return imageCtr.BrowseImage();
        }

        /// <summary>
        /// This method saves an image in the database.
        /// </summary>
        /// <param name="imageLocation"></param>
        /// <returns>DBImage</returns>
        public DBImage InsertImage(string imageLocation)
        {
            return imageCtr.InsertImage(imageLocation);
        }

        /// <summary>
        /// This method find all inventories that do not meet their minimum amount requirements.
        /// </summary>
        /// <returns>inventories</returns>
        public List<Inventory> findAllItemsNotMinim()
        {
            return null; //inventoryDB.findAllItemsNotMinim();
        }
    }
}