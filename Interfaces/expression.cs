using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public  class expression
    {
        //expression bodied members
        public void printmessage() => Console.WriteLine("Hello world");

        //expression bodied properties
        public int square(int x) => x * x;

        //expression bodied constructors
        public expression() => Console.WriteLine("Constructor is called");

    }
}
