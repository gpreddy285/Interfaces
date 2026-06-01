using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Iphonebasic
    {
        void calling();
        void receiving();
        void sendmessage();
        void endcall();
    }

    public class IphoneSe:Iphonebasic
    {
        public void calling() => Console.WriteLine("IphoneSe is calling");
        public void receiving() => Console.WriteLine("IphoneSe is receiving");
        public void sendmessage() => Console.WriteLine("IphoneSe is sending message");
        public void endcall() => Console.WriteLine("IphoneSe is end call");
    }
    interface Iphoneadvanced
    {
        void airdrop();
        void videocall();
        void faceid();
    }
    public class Iphone17 : Iphonebasic, Iphoneadvanced
    {
        public void calling() => Console.WriteLine("Iphoneadvanced is calling");
        public void receiving() => Console.WriteLine("Iphoneadvanced is receiving");
        public void sendmessage() => Console.WriteLine("Iphoneadvanced is sending message");
        public void endcall() => Console.WriteLine("Iphoneadvanced is end call");
        public void airdrop() => Console.WriteLine("Iphoneadvanced has airdrop files sharing feature");
        public void videocall() => Console.WriteLine("Iphoneadvanced has a video calling feature");
        public void faceid() => Console.WriteLine("Iphoneadvanced has a face id feature");
    }

}
