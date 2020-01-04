using System;

namespace ConsoleApp1
{
    class Fibo
    {
        
    }
    
    public class Prime
    {
        static void FIbonacci(int n)
        {
            int a1 = 1, a2 = 1,a=0;
            if (n == 1 || n == 2) Console.WriteLine("ko co:");
            else if(n >= 3 ){
                while (a <= n)
                {
                    a = a1 + a2;
                    a1 = a2;
                    a2 = a;
                    
                }
                    
            }
            Console.WriteLine("so Fibobacci la:"+a1);
        }
    

    static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so: ");
            n = Convert.ToInt32(Console.ReadLine());
            FIbonacci(n);
        }
    }
}