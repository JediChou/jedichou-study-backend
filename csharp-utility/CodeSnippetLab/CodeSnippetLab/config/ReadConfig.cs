using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace CodeSnippetLab.config
{
    public partial class ReadConfig
    {
        public string GetConf(string node)
        {
            var value = ConfigurationSettings.AppSettings[node];
            return value;
        }

        public string GetConf2(string node)
        {
            var appconf = ConfigurationManager.AppSettings;
            return appconf[node];
        }
    }
}
