using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using ExntensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod.Libarary;

namespace ExntensionMethod
{
    class ConfigTest
    {
        
        [Test]
        public static void IsLoaded()
        {
            IConfiguration Config = null;
            Assert.IsFalse(Config.IsLoaded());
        }
        [Test]
        public static void AddStandardProviders() {

            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(config.IsLoaded());
        
        
        }
    }

   
}
