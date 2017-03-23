using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using API.Models.Dto;
using AutoMapper;
using Business.Entities;
using Data;

namespace API.Controllers {
	public class CompanyController : ApiController {
		private readonly ICompanyRepository repo;

		public CompanyController(ICompanyRepository repository) {
			repo = repository;
		}

		// GET: api/Company
		public IEnumerable<CompanyDto> Get() {
			IEnumerable<Company> comps = repo.GetCompanies();

			var res = Mapper.Map<IEnumerable<CompanyDto>>(comps);

			return res;
		}

		// GET: api/Company/5
		public IHttpActionResult Get(int id) {
			Company comp = repo.GetCompanyById(id);
			var res = Mapper.Map<CompanyDto>(comp);

			return Ok(res);
		}

		// POST: api/Company
		public IHttpActionResult Post([FromBody] CompanyDto value) {
			Company company = Mapper.Map<Company>(value);

			repo.InsertCompany(company);
			repo.Save();

			return Ok(company.Id);
		}

		// PUT: api/Company/5
		public IHttpActionResult Put([FromUri] int id, [FromBody] CompanyDto value) {
			Company comp = repo.GetCompanyById(id);

			if (comp != null) {
				value.Id = comp.Id;
				int tempLocationId = comp.Location.LocationId;
				comp = Mapper.Map(value, comp);

				comp.Location.LocationId = tempLocationId;

				repo.UpdateCompany(comp);
				repo.Save();
			}
			else {
				throw new KeyNotFoundException("The Company you're trying to edit doesn't exist");
			}

			var res = Mapper.Map<CompanyDto>(comp);

			return Ok(res);
		}

		// DELETE: api/Company/5
		public IHttpActionResult Delete(int id) {
			repo.DeleteCompany(id);
			repo.Save();
			return StatusCode(HttpStatusCode.NoContent);
		}
	}
}