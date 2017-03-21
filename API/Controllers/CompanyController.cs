using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IMSDemo;
using Data;

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
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Company
        public void Post([FromBody]string value)
        {
            Company comp = new Company { Name = "Some Company" };
            repo.InsertCompany(comp);
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
