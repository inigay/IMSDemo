using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Business.Entities;

namespace Data {
	public class CompanyRepository : ICompanyRepository, IDisposable {
		private readonly IMSDemoContext context;

		private bool disposed;

		public CompanyRepository(IMSDemoContext context) {
			this.context = context;
		}

		public void DeleteCompany(int companyId) {
			Company comp = context.Companies.Find(companyId);
			if (comp.Inventory != null) context.Inventories.Remove(comp.Inventory);
			context.Locations.Remove(comp.Location);
			context.Companies.Remove(comp);
		}


		public IEnumerable<Company> GetCompanies() {
			return context.Companies.ToList();
		}

		public Company GetCompanyById(int companyId) {
			return
				context.Companies.Where(c => c.Id == companyId).Include(c => c.Inventory).Include(c => c.Location).FirstOrDefault();
		}

		public void InsertCompany(Company company) {
			context.Companies.Add(company);
		}

		public void Save() {
			context.SaveChanges();
		}

		public void UpdateCompany(Company company) {
			context.Entry(company).State = EntityState.Modified;
		}

		public void Dispose() {
			throw new NotImplementedException();
		}

		protected virtual void Dispose(bool disposing) {
			if (!disposed) if (disposing) context.Dispose();
			disposed = true;
		}
	}
}