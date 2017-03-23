using System;
using System.Collections.Generic;
using Business.Entities;

namespace Data {
	public interface ICompanyRepository : IDisposable {
		IEnumerable<Company> GetCompanies();
		Company GetCompanyById(int companyId);
		void InsertCompany(Company company);
		void UpdateCompany(Company company);
		void DeleteCompany(int companyId);
		void Save();
	}
}