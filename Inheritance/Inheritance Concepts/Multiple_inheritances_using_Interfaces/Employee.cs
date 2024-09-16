using Inheritance_Concepts.Multiple_inheritances_using_Interfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concepts.Multiple_inheritances_using_Interfaces
{
    public class Employee : IA, IB
    {
        public string Name()
        {
            return "Vishal";
        }

        public int Salary()
        {
            return 25000;
        }
    }
}
