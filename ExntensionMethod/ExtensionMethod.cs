using ExntensionMethod;
using NUnit.Framework;
using System;

namespace ExtensionMethod
{
    public class ExtensionMethod
    {
        IEnumerable<string> _string;
        [SetUp]

        public void Setup()
        {
            _string = new List<string> { "a", "b", "c" };

        }
       
    }
}