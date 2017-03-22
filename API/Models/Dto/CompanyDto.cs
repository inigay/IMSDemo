﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models.Dto
{
    public class CompanyDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string AddressOpt { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public int InventoryId { get; set; }
    }
}