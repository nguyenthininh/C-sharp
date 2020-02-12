using System;
using System.Threading;

namespace ConsoleApp1.Lapsession_3
{
    public class program 
    {
        static void main(string[] args)
        {
            Thread t = new Thread(count);
            // Thread t = new Thread(count);
            t.Start();
        }
        public static void count()
        {
            for(int i = 600;i > 0; i--)
            {
                Console.WriteLine(i / 60 +":"+ i % 60);
                Thread.Sleep(1000);
            }
        }
        
      
    }
}


