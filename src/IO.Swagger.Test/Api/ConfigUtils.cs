using System;
using System.IO;
using YamlDotNet.Serialization;

namespace IO.Swagger.Test.Api
{
    public class ConfigUtils
    {
        private static Config config;
        public static Config loadConfig()
        {
            if (config == null)
            {
                StreamReader stream = new StreamReader("../../resource/config.yaml");
                var des = new DeserializerBuilder().Build();
                config = des.Deserialize<Config>(stream);
            }

            return config;
        }


    }
}
