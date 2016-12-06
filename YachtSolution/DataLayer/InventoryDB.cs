using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.ModelLayer;
using YachtSolution.TechnicalYachtSolutionsDBTableAdapters;

namespace YachtSolution.DataLayer
{
    /// <summary>
    /// This is the class InventoryDb.
    /// </summary>
    public sealed class InventoryDB
    {
        private TechnicalYachtSolutionsDB db;
        private InventoryTableAdapter inventoryAdapter;
        private TechnicalYachtSolutionsDB.InventoryDataTable inventoryTable;

        /// <summary>
        /// This is the constructor for the class InventoryDB.
        /// </summary>
        public InventoryDB()
        {
            db = new TechnicalYachtSolutionsDB();
            inventoryAdapter = new InventoryTableAdapter();
            inventoryAdapter.Fill(db.Inventory);
            inventoryTable = inventoryAdapter.GetData();

        }

        /// <summary>
        /// This method returns all the objects of the class Inventory that lies in the database.
        /// </summary>
        /// <returns>inventories</returns>
        public List<InventoryItem> GetAllInventories()
        {
            List<InventoryItem> inventories = new List<InventoryItem>();

            try
            {
                foreach (TechnicalYachtSolutionsDB.InventoryRow row in inventoryTable)
                {
                    InventoryItem newItem = new InventoryItem(row.name, row.amount, row.description, row.price, row.minimumAmount, row.location, row.manufacturer, row.serialNr, row.partFor, row.suppliers, row.role);
                    inventories.Add(newItem);
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine("Couldn't get all the inventories.");
                Console.WriteLine("Error: " + exception.Message);
                inventories.Clear();
            }

            return inventories;
        }

        //public List<Inventory> GetInventoriesByRole(string role)
        //{
        //    List<Inventory> inventories = GetAllInventories();
        //    if (role != "Administrator")
        //    {
        //        inventories = inventories.Where(i => i.role == role).ToList();
        //    }
        //    return inventories;
        //}

        ///// <summary>
        ///// This method finds and returns a list of objects of the class Inventory that lies in the database by its instance variable name.
        ///// </summary>
        ///// <param name="name"></param>
        ///// <returns>inventories</returns>
        //public List<Inventory> FindItemByName(string name)
        //{
        //    List<Inventory> inventories = new List<Inventory>();

        //    try
        //    {
        //        inventories = (from s in db.Inventories where s.name.Contains(name) select s).ToList();
        //    }

        //    catch (Exception exception)
        //    {
        //        Console.WriteLine("Couldn't find inventories by name.");
        //        Console.WriteLine("Error: " + exception.Message);
        //        inventories.Clear();
        //    }

        //    return inventories;
        //}

        ///// <summary>
        ///// This method finds and returns a list of objects of the class Inventory that lies in the database by its instance variable serialNr.
        ///// </summary>
        ///// <param name="serial"></param>
        ///// <returns>inventories</returns>
        //public List<Inventory> FindItemBySerial(string serial)
        //{
        //    List<Inventory> inventories = new List<Inventory>();

        //    try
        //    {
        //        inventories = db.Inventories.Where(i => i.serialNr == serial).ToList();
        //    }

        //    catch (Exception exception)
        //    {
        //        Console.WriteLine("Couldn't find inventories by serial number.");
        //        Console.WriteLine("Error: " + exception.Message);
        //        inventories.Clear();
        //    }

        //    return inventories;
        //}

        /// <summary>
        /// This method creates an object of the class Inventory and inserts it in the database.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <param name="location"></param>
        /// <param name="manufacturer"></param>
        /// <param name="minimumAmount"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="serialNr"></param>
        /// <returns>success</returns>
        public bool InsertItem(string name, int amount, string description, double price, int minimumAmount, string location, string manufacturer, string serialNo, string partFor, string suppliers, string role)
        {
            bool success;

            try
            {
                TechnicalYachtSolutionsDB.InventoryRow inventoryRow = db.Inventory.NewInventoryRow();

                inventoryRow.name = name;
                inventoryRow.amount = amount;
                inventoryRow.description = description;
                inventoryRow.price = price;
                inventoryRow.minimumAmount = minimumAmount;
                inventoryRow.location = location;
                inventoryRow.manufacturer = manufacturer;
                inventoryRow.serialNr = serialNo;
                inventoryRow.partFor = partFor;
                inventoryRow.suppliers = suppliers;
                inventoryRow.role = role;

                db.Inventory.Rows.Add(inventoryRow);

                inventoryAdapter.Insert(name, amount, description, price, minimumAmount, location, manufacturer, serialNo, null, partFor, suppliers, role);
                inventoryAdapter.Update(db.Inventory);
                
                db.AcceptChanges();
                success = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Couldn't create the inventory.");
                Console.WriteLine("Error: " + exception.Message);
                success = false;
            }

            return success;
        }

        ///// <summary>
        ///// This method finds and deletes an object of the class Inventory from the database by its instance variable serialNr.
        ///// </summary>
        ///// <param name="serialNr"></param>
        ///// <returns>success</returns>
        //public bool DeleteItem(string serialNr)
        //{
        //    bool success;
        //    Inventory inventory;

        //    try
        //    {
        //        inventory = (from x in db.Inventories where x.serialNr == serialNr select x).First();

        //        db.Inventories.DeleteOnSubmit(inventory);
        //        db.SubmitChanges();
        //        success = true;
        //    }

        //    catch (Exception exception)
        //    {
        //        Console.WriteLine("Couldn't delete the inventory.");
        //        Console.WriteLine("Error: " + exception.Message);
        //        success = false;
        //    }

        //    return success;
        //}

        ///// <summary>
        ///// This method finds and updates an object of the class Inventory from the database by its instance variable serialNr.
        ///// </summary>
        ///// <param name="description"></param>
        ///// <param name="amount"></param>
        ///// <param name="location"></param>
        ///// <param name="manufacturer"></param>
        ///// <param name="minimumAmount"></param>
        ///// <param name="name"></param>
        ///// <param name="price"></param>
        ///// <param name="serialNr"></param>
        ///// <returns>success</returns>
        //public bool UpdateItemBySerial(string description, int amount, string location, string manufacturer, int minimumAmount, string name, double price, string serialNr, DBImage photo, string partFor, string suppliers)
        //{
        //    bool success;
        //    Inventory inventory;

        //    try
        //    {
        //        inventory = db.Inventories.SingleOrDefault(i => i.serialNr == serialNr);
        //        inventory.description = description;
        //        inventory.amount = amount;
        //        inventory.location = location;
        //        inventory.manufacturer = manufacturer;
        //        inventory.minimumAmount = minimumAmount;
        //        inventory.name = name;
        //        inventory.price = price;

        //        if (photo != null)
        //        {
        //            inventory.DBImage = db.DBImages.ToList().First(i => i.ImageID == photo.ImageID);
        //        }

        //        inventory.partFor = partFor;
        //        inventory.suppliers = suppliers;

        //        db.SubmitChanges();

        //        success = true;
        //    }

        //    catch (Exception exception)
        //    {
        //        Console.WriteLine("Couldn't update the inventory.");
        //        Console.WriteLine("Error: " + exception.Message);
        //        success = false;
        //    }

        //    return success;
        //}

        ///// <summary>
        ///// This method finds and returns a list of objects of the class Employee from the database that doesn't meet their minimum requirements.
        ///// </summary>
        ///// <returns>inventories</returns>
        //public List<Inventory> findAllItemsNotMinim()
        //{
        //    List<Inventory> inventories = new List<Inventory>();

        //    try
        //    {
        //        inventories = (from a in db.Inventories where a.amount < a.minimumAmount select a).ToList();
        //    }

        //    catch (Exception exception)
        //    {
        //        Console.WriteLine("Couldn't find the inventories that not meet the minimum amount.");
        //        Console.WriteLine("Error: " + exception.Message);
        //        inventories.Clear();
        //    }

        //    return inventories;
        //}
    }
}