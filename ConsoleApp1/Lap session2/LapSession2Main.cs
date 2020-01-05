using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.Lap_session2
{
    public class LapSession2Main
    {
        static void Main(string[] args)
        {
         List<string> gallery = new List<string>();
         Product p = new Product();
            //p.inputInfo();
            //p.getInfo();
            //p.CheckSoLuong();
            while (true)
            {
                Console.WriteLine("Duoi day la cac lua chon:");
                Console.WriteLine("1-điền thông tin san pham:");
                Console.WriteLine("2-thong tin san pham la:");
                Console.WriteLine("3-kiểm tra số lượng.");
                Console.WriteLine("4-Thêm ảnh.");
                Console.WriteLine("5-xóa ảnh.");
                Console.WriteLine("0-exit.");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    
                    case 1: p.inputInfo();break;
                    case 2: p.getInfo(); break;
                    case 3: p.CheckSoLuong(); break;
                    

                }
            }
                
                
                
            
            
        }
    }
}