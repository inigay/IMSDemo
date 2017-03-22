using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSDemo
{
    public class Location
    {
        [Key]
        [ForeignKey("Company")]
        public int LocationId { get; set; }

        public string Address { get; set; }

        public string AddressOpt { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }
        
        [Required]
        public virtual Company Company { get; set; }

    }
}
