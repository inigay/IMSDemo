using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMSDemo;
using System.Data.Entity;

namespace DataLayer
{
    public class CompanyRepository : ICompanyRepository, IDisposable
    {
        private IMSContext context;

        public CompanyRepository(IMSContext context)
        {
            this.context = context;
        }

        public void DeleteCompany(int companyId)
        {
            Company company = context.Companies.Find(companyId);
            context.Companies.Remove(company);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<Company> getCompanies()
        {
            return context.Companies.ToList();
        }

        public Company getCompany(int companyId)
        {
            return context.Companies.Find(companyId);
        }

        public void InsertCompany(Company company)
        {
            context.Companies.Add(company);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateCompany(Company company)
        {
            context.Entry(company).State = EntityState.Modified;
        }
    }
}
