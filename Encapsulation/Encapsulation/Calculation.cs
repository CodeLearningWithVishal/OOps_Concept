using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        private int Sub(int c, int d)
        {
            return c - d;
        }
        protected int Div(int e, int f)
        {
            return e / f;
        }

    }
}
