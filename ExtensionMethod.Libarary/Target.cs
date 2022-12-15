using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Libarary
{
    public class Target
    {
        private string _id;

        protected string ID {
            get { return _id; }

            set { _id = value.Trim(); } 
        }
        public string GetID()
        {
            return _id;
        }
        public Target (string id)
        {
            _id = id;
        }
    }
    internal class InternalTarget
    {
        protected class ProtectedSubClass
        {

        }
    }
}
