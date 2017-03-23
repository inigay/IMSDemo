using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Entities {
	public class Inventory {
		[Key]
		[ForeignKey("Company")]
		public int InventoryId { get; set; }

		public string Category { get; set; }

		public virtual ICollection<Item> Items { get; set; }

		[Required]
		public virtual Company Company { get; set; }
	}
}