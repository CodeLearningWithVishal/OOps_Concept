using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concepts.Hierarchical_inheritance
{
    internal class B : A
    {
        public string Information()
        {
            Message();
            return "this is B class Method";
        }        
    }
}
