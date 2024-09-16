using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concepts.Multilevel_inheritance
{
    internal class C : B
    {
        public string MessageC() {
            Message();
            MessageB();
            return "This is Class C";
        }
    }
}
