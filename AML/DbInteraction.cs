using System;
using System.Linq;


namespace AML
{
    public class DbInteraction
    {
        public DbInteraction() { }

        public void AddShareholder(Shareholder shareholder)
        {
            using (AMLEntities db = new AMLEntities())
            {
                db.Shareholders.Add(shareholder);
                db.SaveChanges();
                Console.WriteLine("New shareholder added:" + shareholder.FirstName);
            }
        }

        public void AddCompany(Company company)
        {
            using (AMLEntities db = new AMLEntities())
            {
                db.Companies.Add(company);
                db.SaveChanges();
                Console.WriteLine("New company added:" + company.Name);
            }
        }

        public void GetAllCompanies()
        {
            using (AMLEntities db = new AMLEntities())
            {
                var company_list = db.Companies.ToList();
                foreach (var company in company_list)
                {
                    Console.WriteLine(company.Name + " " + company.CUI);
                }
            }
        }

        public Company GetCompanyByName(string fname)
        {
            using (AMLEntities db = new AMLEntities())
            {
                var company = (from s in db.Companies
                               where s.Name == fname
                               select s).FirstOrDefault<Company>();
                return company;
            }
        }
    }
 }
