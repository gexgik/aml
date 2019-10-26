﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AML
{
    class ParseInfoJson
    {
        private DbInteraction mDb;

        public ParseInfoJson()
        {
            mDb = new DbInteraction();
        }

        public void fillDB()
        {
            string[] json_files = new string[] { "1.json", "2.json" };
            string str1 = "{\"nume\":\"involvesWatchonly\"}";

            string str2 = "";

            string[] json_files_mem = new string[] { str1, str2 };


            int nr_json_files = 2;
            int count = 0;
            bool jsonParsed = false;

            string currentDir = Directory.GetCurrentDirectory();
            if (string.IsNullOrEmpty(currentDir))
            {
                Console.WriteLine("Cannot build path: current dir empty");
                System.Environment.Exit(1);
            }
            DirectoryInfo parent = Directory.GetParent(currentDir);
            if (parent == null)
            {
                Console.WriteLine("Cannot build path: parent dir empty");
                System.Environment.Exit(1);
            }

            string dir = parent.Parent.FullName;

            if (string.IsNullOrEmpty(dir))
            {
                Console.WriteLine("Cannot build path: dir empty");
                System.Environment.Exit(1);
            }

            for (int i = 0; i < json_files.Length; i++)
            {
                string path = "D:\\aml\\aml\\"+ json_files[i];
                ParserJson parserJson = new ParserJson(path);

                // Read all info from json
                RootJsonObject rootObj = null;

                bool parsed = parserJson.LoadJson(parserJson.JsonString, ref rootObj);
                if (!parsed)
                {
                    Console.WriteLine("Read transactions from memory");
                    parsed = parserJson.LoadJson(json_files_mem[i], ref rootObj);
                }

                // Store all data in a database
                if (rootObj != null && parsed)
                {
                    SaveToDB(rootObj);
                    count++;
                }
            }
           
        }

        public void SaveToDB(RootJsonObject rootobj)
        {
            //foreach (var item in rootobj.da)
            {
                Company company = new Company();
                company.Name = rootobj.Name;
                //company.CUI = item["cui"];

                mDb.AddCompany(company);
            }
        }
    }
}
