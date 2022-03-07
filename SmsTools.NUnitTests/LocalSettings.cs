using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.NUnitTests
{
    public class LocalSettings
    {
        public static bool Setup(string jsonFileName = "")
        {
            if (string.IsNullOrWhiteSpace(jsonFileName))
            {
                jsonFileName = "local.settings.json";
            }
            string jsonFileText = File.ReadAllText(jsonFileName);

            var myDeserializedClass = JsonConvert.DeserializeObject<JsonObject_LocalSettings>(jsonFileText);

            if(myDeserializedClass is not null && myDeserializedClass.Values is not null)
            {
                foreach (var environmentVariable in myDeserializedClass.Values)
                {
                    Environment.SetEnvironmentVariable(environmentVariable.Key, environmentVariable.Value);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class JsonObject_LocalSettings
    {
        public bool IsEncrypted { get; set; }
        public Dictionary<string,string>? Values { get; set; }
    }


}
