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
            ParseInfoJson parser  = new ParseInfoJson();
            parser.fillDB();

            string transactionFrom = "A";
            string transactionTo = "B";

            string UBOFromName = GetUBO(transactionFrom);
            string UBOToName = GetUBO(transactionTo);

            ValidateUBO(UBOFromName);
            ValidateUBO(UBOToName);

        }

        private static void ValidateUBO(string uBOToName)
        {
        }

        private static string GetUBO(string transactionFrom)
        {
            return "";
        }
    }
}
