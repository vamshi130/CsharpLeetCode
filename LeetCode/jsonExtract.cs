using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Dictionaries
{
    static internal class jsonExtract
    {
        public static void Extract() {
            string filePath = "C:/Users/Vamshi.Krishna/Downloads/Ecom/Taxonomy/lookupTables_brand.json";
            string outputFilePath = "C:/Users/Vamshi.Krishna/Downloads/Ecom/Taxonomy/lookupTables_brand2.json";
            string failedEntityCodes = "C:/Users/Vamshi.Krishna/Downloads/part-00000-8ced09f5-6c02-48a8-82ef-f304108be042-c000 (1).json";

            // Read the contents of the input file
            string fileContents = File.ReadAllText(filePath);

            JArray categories = JArray.Parse(fileContents);
            //string fc = File.ReadAllText(failedEntityCodes);
            //JObject jb = JObject.Parse(fc);
            //JArray array = JArray.FromObject(jb);


            // Assuming you have a list of entity codes you want to compare against the parent entity code
            List<string> entityCodesToCompare = new List<string>() { };
            foreach (string line in File.ReadAllLines(failedEntityCodes))
            {
                JObject jsonObject = JObject.Parse(line);
                string entityCode = (string)jsonObject["entityCode"];
                entityCodesToCompare.Add(entityCode);
                // Do something with the entityCode
            }
            foreach (var category in categories)
            {
                var parentEntityCode = category["entityCode"].ToString();

                // Check if the parent entity code is in the list of entity codes to compare
                if (entityCodesToCompare.Contains(parentEntityCode))
                {
                    string entityJson = category.ToString();
                    File.AppendAllText(outputFilePath, entityJson + Environment.NewLine);
                }
            }
        }
    }
}
