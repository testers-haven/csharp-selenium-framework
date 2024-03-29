﻿using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace TestingFramework
{
    public class ConfigManager
    {
        private static readonly Lazy<IConfigurationRoot> _lazy =
         new(() => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build());

        public static IConfigurationRoot AppSettings { get { return _lazy.Value; } }

        static ConfigManager() { }

        private ConfigManager() { }
    }
}
