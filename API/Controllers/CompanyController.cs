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
        public IEnumerable<Company> Get()
        {
            return repo.GetCompanies();
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
                
            };

            return Ok(res);
        }

        // POST: api/Company
        public void Post([FromBody]string value)
        {
            var company = new Company { Name = "Some Company" };
            var inv = new Inventory { Category = "Some Category" };

            company.Inventory = inv;

            repo.InsertCompany(company);
            repo.Save();

        }

        // PUT: api/Company/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Company/5
        public void Delete(int id)
        {
        }
    }
}
