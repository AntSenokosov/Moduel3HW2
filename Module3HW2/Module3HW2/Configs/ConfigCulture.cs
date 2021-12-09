using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Module3HW2.Configs
{
    public class ConfigCulture
    {
        private readonly string _path = "Configs/config.json";
        private Dictionary<string, List<string>> _cultures;

        public ConfigCulture()
        {
            _cultures = InitCultures();
        }

        public Dictionary<string, List<string>> InitCultures()
        {
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(File.ReadAllText(_path));

            return dictionary;
        }
    }
}
