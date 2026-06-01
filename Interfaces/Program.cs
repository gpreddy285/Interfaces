using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape c = new circle { radious = 10 };

            c.Area();
            c.perimeter();
            IShape r = new rectangle{length = 10, width = 8};
            r.Area();
            r.perimeter();

        }
    }
}
