using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMSDemo
{
    public class Company
    {
        public Company()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }    

        public virtual IEnumerable<Location> Location { get; set; }

        [ForeignKey("Id")]
        public virtual Inventory Inventory { get; set; }

        public void Reset()
        {
            this.Location = null;
            this.Name = null;
            this.Inventory = null;
        }
        
    }
}
