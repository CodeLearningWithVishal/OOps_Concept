using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("dog can sound");
        }
    }
}
