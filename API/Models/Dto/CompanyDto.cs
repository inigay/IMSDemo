using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models.Dto
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Locations { get; set; }
        public int InventoryId { get; set; }
    }
}