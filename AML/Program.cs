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
            ParseInfoJson parser = new ParseInfoJson();
            parser.fillDB();
        }
    }
}
