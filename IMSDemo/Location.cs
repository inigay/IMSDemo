using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSDemo
{
    public class Location
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string AddressOpt { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int zip { get; set; }

        [Required]
        public virtual Company Company { get; set; }

    }
}
