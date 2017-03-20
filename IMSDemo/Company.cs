using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSDemo
{
    class Company
    {
        public Company()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }

        public Inventory Inventory { get; set; }

        public void Reset()
        {
            this.Location = null;
            this.Name = null;
            this.Inventory = null;
        }
        
    }
}
