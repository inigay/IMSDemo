using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMSDemo;

namespace Data
{
    public class CompanyRepository : ICompanyRepository
    {
        private IMSDemoContext context;

        public CompanyRepository(IMSDemoContext context)
        {
            this.context = context;
        }

        public void DeleteCompany(int companyId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompanies()
        {
            return context.Companies.ToList();
        }

        public Company GetCompanyById(int companyId)
        {
            throw new NotImplementedException();
        }

        public void InsertCompany(Company company)
        {
            context.Companies.Add(company);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCompany(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
