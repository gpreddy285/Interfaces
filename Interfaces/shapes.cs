using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IShape
    {
         void Area();
        void perimeter();
    }

    public class circle:IShape
    {
        public double radious { get; set; }

        public void Area()
        {
            Console.WriteLine("Area of a circle is :" + (Math.PI * radious * radious));
        }
        public void perimeter()
        {
            Console.WriteLine("Perimeter of a circle is :" + (2 * Math.PI*radious));
        }
    }
    public class rectangle : IShape
    {
        public double length { get; set; }
        public double width { get; set; }
        public void Area()
        {
            Console.WriteLine("Area of rectangle is :" + (length * width));
        }
        public void perimeter()
        {
            Console.WriteLine("perimeter of rectangle is :" + 2 * (length + width));
        }
    }

}
