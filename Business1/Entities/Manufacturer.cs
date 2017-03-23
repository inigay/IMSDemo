using System.Collections.Generic;

namespace Business.Entities {
	public class Manufacturer {
		public int Id { get; set; }

		public string Name { get; set; }

		public virtual ICollection<Item> Items { get; set; }
	}
}