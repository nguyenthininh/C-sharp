using System;
using ConsoleApp1.Lap_session2;

namespace ConsoleApp1.DelegateDemo
{
    
    //khai bao 1 delegate
    public delegate void DemoDelegate(string s);

    public class Session3
    {
        public event DemoDelegate demoEvent;
        
        static void Main(string[] args)
        {
            //tao 1 the hien cua delegate
            
            // DemoDelegate dd = new DemoDelegate(SayHello);
            // dd("abc xyz");   //tg tu SayHello("abc xyz");
            // DemoDelegate dd2 = new DemoDelegate(new Session3().SayAnything);
            // dd2("hello world");  // tg tu SayAnyThing("hello world");
            // dd += dd2;  //dd=dd+ dd2;
            
            //SayHello("T1904A");
            //SayAnything("T1904A")
           // dd("T1904A");
           
           //Session3 s3 = new Session3();
           // s3.RunEvent();
           
           Product p = new Product();
           p.Price = 20000;
           Console.WriteLine("Tien da co");
           p.Price = 30000;
        }
        
        public void RunEvent()
        {
            if (demoEvent == null)
            {
                demoEvent += SayHello;
            }

            demoEvent("Chay thu nghiem");
        }

        public static void SayHello(string str)
        {
            Console.WriteLine("Say hello" +str);
        }

        public void SayAnything(string ss)
        {
            Console.WriteLine("Say Anything"+ss);
        }
        
    }
}