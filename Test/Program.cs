using Data;
using IMSDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new CompanyRepository(new IMSDemoContext());

            var companies = repo.GetCompanies();

            foreach (var item in companies)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
