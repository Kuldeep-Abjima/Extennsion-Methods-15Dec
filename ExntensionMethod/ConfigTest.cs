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
        public static void Main(string[] args)
        {
            IsLoaded();
        }
        
        [Test]
        public static void IsLoaded()
        {
            IConfiguration Config = null;
            Assert.IsFalse(Config.IsLoaded());
        }
    }

   
}
