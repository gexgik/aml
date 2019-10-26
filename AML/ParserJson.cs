using System;
using System.IO;
using Newtonsoft.Json;

namespace AML
{
    public class ParserJson
    {
        public ParserJson(string InputFile)
        {
            mInputFilename = InputFile;
            JsonString = "";
        }

        private void ReadJson()
        {
            try
            {
                if (!File.Exists(mInputFilename))
                {
                    Console.WriteLine("File does not exist: {0}", mInputFilename);
                    return;
                }

                using (StreamReader r = new StreamReader(mInputFilename))
                {
                    JsonString = r.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Process failed {0} {1}", e.ToString());
            }
        }

        public string JsonString { set; get; }


        public bool LoadJson(string jsonString, ref RootJsonObject jsonObj)
        {
            ReadJson();

            if (string.IsNullOrEmpty(jsonString))
            {
                return false;
            }

            jsonObj = JsonConvert.DeserializeObject<RootJsonObject>(jsonString);

            return true;
        }

        private string mInputFilename;
    }
}
