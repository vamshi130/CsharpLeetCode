using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public static class JsonSplitter
    {
        public static void jsonsplit()
        {
            string inputFilePath = "C:/Users/Vamshi.Krishna/Downloads/Ecom/dataframeRows_ecommerce_dataframerows_brandShares.json";
            string inputContents = File.ReadAllText(inputFilePath);
            JArray inputArray = JArray.Parse(inputContents);
            int inputCount = inputArray.Count;
            int outputCount = inputCount / 2;
            JArray outputArray1 = new JArray();
            JArray outputArray2 = new JArray();
            for (int i = 0; i < inputCount; i++)
            {
                JObject currentObject = (JObject)inputArray[i];
                if (i < outputCount)
                {
                    outputArray1.Add(currentObject);
                }
                else
                {
                    outputArray2.Add(currentObject);
                }
            }
            string outputContents1 = outputArray1.ToString();
            string outputContents2 = outputArray2.ToString();
            string outputFilePath1 = "C:/Users/Vamshi.Krishna/Downloads/Ecom/updated/brandsDataframes1";
            string outputFilePath2 = "C:/Users/Vamshi.Krishna/Downloads/Ecom/updated/brandsDataframes2";
            File.WriteAllText(outputFilePath1, outputContents1);
            File.WriteAllText(outputFilePath2, outputContents2);
        }
    }
}
