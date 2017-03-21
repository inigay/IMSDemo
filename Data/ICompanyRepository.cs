using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMSDemo;

namespace Data
{
    public interface ICompanyRepository : IDisposable
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompanyById(int companyId);
        void InsertCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(int companyId);
        void Save();
    }
}
