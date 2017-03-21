using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMSDemo
{
    public class Inventory
    {
        [Key]
        [Column("InventoryId")]
        public int Id { get; set; }

        public string Category { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        [Required]
        public Company Company { get; set; }
    }
}
