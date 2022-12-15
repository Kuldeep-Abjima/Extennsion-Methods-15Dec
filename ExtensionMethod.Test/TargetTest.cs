using ExtensionMethod.Libarary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class TargetTest
    {
        [Test]
        public void StandardID()
        {
            var obj = new Target("Id01");
            Assert.AreEqual("ID01", obj.GetStandardizeID());

        }


    }
}
