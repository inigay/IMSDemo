using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSDemo
{
    class Inventory
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public IEnumerable<Item> Items { get; set; }

        public IEnumerable<Manufacturer> MyProperty { get; set; }
    }
}
