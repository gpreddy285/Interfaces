using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Ipaymentgateway
    {
       void processpayment();
    }

    public class paypalgateway:Ipaymentgateway
    {
        public void processpayment() => Console.WriteLine("payment is processed through paypal");
    }
    public class upigateway : Ipaymentgateway
    {
        public void processpayment() => Console.WriteLine("payment is processed through upi");
    }
    public class creditcard : Ipaymentgateway
    {
        public void processpayment() => Console.WriteLine("payment is processed through credit card");
    }
    public class debitcard : Ipaymentgateway
    {
        public void processpayment() => Console.WriteLine("payment is processed through debit card");
    }

}
