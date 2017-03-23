using System.ComponentModel.DataAnnotations;

namespace Business.Entities {
	public class Company {
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public virtual Location Location { get; set; }

		public virtual Inventory Inventory { get; set; }


		public void Reset() {
			Location = null;
			Name = null;
			Inventory = null;
		}
	}
}