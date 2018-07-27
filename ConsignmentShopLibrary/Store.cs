using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }

        // Constructor Function to instantiate Item and Vendor Lists upon creation of store instance
        public Store()
        {
            Items = new List<Item>();
            Vendors = new List<Vendor>();
        }
    }
}
