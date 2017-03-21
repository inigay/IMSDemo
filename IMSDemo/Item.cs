using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMSDemo
{
    public class Item
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int ItemsInStock { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
        
        public virtual ICollection<Manufacturer> Manufacturers { get; set; }


        public void Activate(bool isActive)
        {
            this.IsActive = isActive;
        }
        

    }
}
