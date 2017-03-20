using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSDemo
{
    class Item
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int ItemsInStock { get; set; }

        public bool IsActive { get; set; }


        public void Activate(bool isActive)
        {
            this.IsActive = isActive;
        }
        

    }
}
