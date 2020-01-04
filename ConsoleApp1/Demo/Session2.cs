using System;

namespace ConsoleApp1
{
    public class Session2
    {
        static void Main(string[] args)
        {
            Human h = new Human();  //hàm khởi tạo
            h.SayHello();
            h.SayHello("Anna");
            Asian a = new Asian();
            a.SayHello();
            h.Age = 12;
            Console.WriteLine("tuoi:" +h.Age);
            h.Age = -1;  // chính là cái Value trong hàm set
            Console.WriteLine("tuoi 2 :" +h.Age);

            a.telephone[0] = "098765432";
            a.telephone[1] = "23467867";

            a[2] = "098764234";
            a[3] = "092345678";
            Console.WriteLine("chỉ mục 1: " +a[1]);
            
            // List<string> strList = new List<string>();
            //strList.Add("aa");
            //strLisst[1] = "bb";
        }
    }
}