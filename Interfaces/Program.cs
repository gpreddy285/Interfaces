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

            /* IShape c = new circle { radious = 10 };
             c.Area();
             c.perimeter();
             IShape r = new rectangle{length = 10, width = 8};
             r.Area();
             r.perimeter();*/

            /*expression obj = new expression();
            obj.printmessage();
            double result = obj.square(17);
            Console.WriteLine("The square result is :" + result);*/

            /*Iphonebasic obj1 = new IphoneSe();
            obj1.calling();
            obj1.receiving();
            obj1.sendmessage();
            obj1.endcall();
            obj1 = new Iphone17();
            obj1.calling();
            obj1.receiving();
            obj1.sendmessage();
            obj1.endcall();
            Iphoneadvanced obj2 = new Iphone17();
            obj2.faceid();
            obj2.videocall();
            obj2.faceid();*/

            Ipaymentgateway ipg = new paypalgateway();
            ipg.processpayment();
            ipg = new upigateway();
            ipg.processpayment();
            ipg = new creditcard();
            ipg.processpayment();
            ipg = new debitcard();
            ipg.processpayment();



        }
    }
}
