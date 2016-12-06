using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YachtSolution.ModelLayer
{
    public class InventoryItem
    {
        public string Description { get; set; }
        public int Amount { get; set; }
        public string Location { get; set; }
        public string Manufacturer { get; set; }
        public int MinimumAmount { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string SerialNo { get; set; }
        public string PartFor { get; set; }
        public string Suppliers { get; set; }
        public string Role { get; set; }

        public InventoryItem(string name, int amount, string description, double price, int minimumAmount, string location, string manufacturer, string serialNo, string partFor, string suppliers, string role)
        {
            Description = description;
            Amount = amount;
            Location = location;
            Manufacturer = manufacturer;
            MinimumAmount = minimumAmount;
            Name = name;
            Price = price;
            SerialNo = serialNo;
            PartFor = partFor;
            Suppliers = suppliers;
            Role = role;
        }
    }
}
