using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concepts.Multilevel_inheritance
{
    internal class B : A
    {
        public string MessageB() {
            Message();
            return "This is class B";
        }
    }
}
