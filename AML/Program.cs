using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AML
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Company company = new Company
            {
                Name = "A",
                CUI = "A",
                Sales = 99999,
                Profit=111000,
                Shareholders="A,B,C,D"
            };
            AddCompany(company);
            GetAllCompanies();*/
            ParseInfoJson parser = new ParseInfoJson();
            parser.fillDB();
        }
    }
}
