using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenagjimiAutobusav.DAL
{
    public class DBHelper
    {

        public static string GetConnectionString()
        {
            //Urata : C:\Users\RS Computers\Source\Repos\MenagjimiAutobusav\MenagjimiAutobusav.DAL\AppSettings.json
            //Diellza : C:\Users\huawei\Desktop\Viti 2\Projekti TI-1\Projekti\MenagjimiAutobusav.DAL\AppSettings.json
            //Fatbardha : C:\\Users\\HP\\Source\\Repos\\MenagjimiAutobusav\\MenagjimiAutobusav.DAL\\AppSettings.json
            var path = Path.Combine("C:\\Users\\RS Computers\\Source\\Repos\\MenagjimiAutobusav\\MenagjimiAutobusav.DAL\\AppSettings.json");
            var file = File.ReadAllText(path);
            var jObject = JObject.Parse(file);
            var connectionString = (string)jObject["ConnectionStrings"]["Urata"];
            return connectionString;
        }
    }
}
