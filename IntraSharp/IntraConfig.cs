using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;

namespace IntraSharp
{
    public class IntraConfig
    {
        public string ConfigPath { get; set; }
        public IntraConfiguration Config { get; set; }

        public void SaveConfig()
        {
            File.WriteAllText(ConfigPath, JsonConvert.SerializeObject(Config));
        }

        public static IntraConfig LoadConfig(string configPath)
        {
            IntraConfig config = new IntraConfig();
            config.Config = JsonConvert.DeserializeObject<IntraConfiguration>(File.ReadAllText(configPath));
            config.ConfigPath = configPath;
            return config;
        }

    }
}
