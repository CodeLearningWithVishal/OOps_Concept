using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concepts.Single_inheritance
{
    internal class Debit: Account       //derived class
    {
        public string debit()
        {
            Credit();                       ////derived class method
            return "balance is debited";
        }
    }
}
