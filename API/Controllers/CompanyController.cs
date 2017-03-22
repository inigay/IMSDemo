using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IMSDemo;
using Data;
using API.Models.Dto;

namespace API.Controllers
{
    public class CompanyController : ApiController
    {
        private ICompanyRepository repo;

        public CompanyController()
        {
            this.repo = new CompanyRepository(new IMSDemoContext());
        }

        // GET: api/Company
        public IEnumerable<CompanyDto> Get()
        {
            IEnumerable<Company> comps = repo.GetCompanies();

            var res = from comp in comps
                      select new CompanyDto
                      {
                          Id = comp.Id,
                          Name = comp.Name,
                          InventoryId = comp.Inventory.InventoryId,
                          Address = (comp.Location == null) ? "" : comp.Location.Address,
                          AddressOpt = (comp.Location == null) ? "" : comp.Location.AddressOpt,
                          City = (comp.Location == null) ? "" : comp.Location.City,
                          State = (comp.Location == null) ? "" : comp.Location.State,
                          Zip = (comp.Location == null) ? 0 : comp.Location.Zip
                      };
            return res;
        }

        // GET: api/Company/5
        public IHttpActionResult Get(int id)
        {
            Company comp = repo.GetCompanyById(id);
            var res = new CompanyDto
            {
                Id = comp.Id,
                Name = comp.Name,
                InventoryId = comp.Inventory.InventoryId,
                Address = comp.Location.Address,
                AddressOpt = comp.Location.AddressOpt,
                City = comp.Location.City,
                State = comp.Location.State,
                Zip = comp.Location.Zip
            };

            return Ok(res);
        }

        // POST: api/Company
        public IHttpActionResult Post([FromBody]CompanyDto value)
        {
            Company company = new Company {
                Name = value.Name,
                Location = new Location
                {
                    Address = value.Address,
                    AddressOpt = value.AddressOpt,
                    City = value.City,
                    State = value.State,
                    Zip = value.Zip
                },
                Inventory = new Inventory()
            };

            
            repo.InsertCompany(company);
            repo.Save();

            return Ok();

        }

        // PUT: api/Company/5
        public void Put([FromUri]int id, [FromBody]CompanyDto value)
        {

        }

        // DELETE: api/Company/5
        public void Delete(int id)
        {
        }
    }
}
