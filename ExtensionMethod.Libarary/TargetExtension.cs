using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Libarary
{
     public static  class TargetExtension
    {
        static void ExntendedClass(this InternalTarget target)
        {

        }

        public static string GetStandardizeID(this Target target)
        {
            return target.GetID().ToUpper();
        }
    }
}
