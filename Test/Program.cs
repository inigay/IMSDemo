using System;
using Data;

namespace Test {
	internal class Program {
		private static void Main(string[] args) {
			var repo = new CompanyRepository(new IMSDemoContext());

			var companies = repo.GetCompanies();

			foreach (var item in companies) Console.WriteLine(item.Name);
		}
	}
}