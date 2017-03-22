using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMSDemo
{
    public class Company
    {
        public Company()
        {

        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Location> Location { get; set; }

        public virtual Inventory Inventory {get;set;}


        public void Reset()
        {
            this.Location = null;
            this.Name = null;
            
        }
        
    }
}
