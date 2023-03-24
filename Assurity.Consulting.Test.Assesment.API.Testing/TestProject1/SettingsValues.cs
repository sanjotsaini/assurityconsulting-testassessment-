

using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AssurityConsultingTestAssessment
{
    public  class SettingsValues
    {

        public static string GetSettingsValues(string settingValueName)
        {
            IConfiguration builder = new ConfigurationBuilder()               
               .AddJsonFile("appSettings.json")
               .Build();
            string value = builder.GetValue<string>(settingValueName);
            if (value == null || value == string.Empty || value == "")
            {
                throw new KeyNotFoundException("'key Not found");
            }
            else { return value; }
        }
    }
}
