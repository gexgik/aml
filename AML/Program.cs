using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AML
{
    class Program
    {
        static void AddCompany(Company company)
        {
            using (AMLEntities db = new AMLEntities())
            {
                db.Company.Add(company);
                db.SaveChanges();
                Console.WriteLine("New company added:" +  company.Name);
            }
        }

        static void GetAllCompanies()
        {
            using (AMLEntities db = new AMLEntities())
            {
                var company_list = db.Company.ToList();
                foreach (var company in company_list)
                {
                    Console.WriteLine(company.Name + " " + company.CUI);
                }
            }
        }

        static Company GetCompanyByName(string fname)
        {
            using (AMLEntities db = new AMLEntities())
            {
                var company = (from s in db.Company
                              where s.Name == fname
                              select s).FirstOrDefault<Company>();
                return company;
            }
        }

        static void Main(string[] args)
        {
            Company company = new Company
            {
                Name = "A",
                CUI = "A",
                Sales = 99999,
                Profit=111000,
                Shareholders="A,B,C,D"
            };
            AddCompany(company);
            GetAllCompanies();

        }
    }
}
