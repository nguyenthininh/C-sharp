using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;

namespace ConsoleApp1.Lap_session2
{
    public class Product
    {
        public int id;
        public string name;
        public double  price;
        public int qty;
        public string desc;
        public List<string> gallery = new List<string>();
        //public List<string> gallery;
        
        public Product(){
    
        }

        public Product(int id, string name,double price, int qty, string desc,List<string> gallery )
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.desc = desc;
            this.gallery = gallery;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> ProductList
        {
            get => gallery;
            set => gallery = value;
        }


        public void inputInfo()
        {
            Console.WriteLine("nhap thong tin san pham :");
            Console.WriteLine("nhap id:");
            this.Id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten sp:");
            this.Name = Console.ReadLine();
            Console.WriteLine("nhap gia sp:");
            this.Price= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap so luong sp:");
            this.Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mô tả sản phẩm:");
            this.desc = Console.ReadLine();
            this.addImg();

        }

        public void getInfo()
        {
            Console.WriteLine("thong tin sna pham la:");
            Console.WriteLine("Id:"+this.id);
            Console.WriteLine("Name:" +this.name);
            Console.WriteLine("Price:" +this.price);
            Console.WriteLine("amount:" +this.qty);
            Console.WriteLine("Mo ta san pham:" + desc);
            Console.WriteLine("Anh san pham:");
            foreach(String t in gallery){
                Console.WriteLine(t);
            }
            
        }

        public Boolean CheckSoLuong()
        {
            if (this.qty >0)
            {
                Console.WriteLine("con hang.");
                return true;
            }
            Console.WriteLine("het hang.");
            return false;
        }

        public void addImg()
        {
            int i = 0;
            int index;
            string s;
            while(true){
                if (i == 10)
                {
                    Console.WriteLine("Thư viện đầy,chọn ảnh thay thế");
                    index = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập ảnh mới:");
                    s = Console.ReadLine();
                    this.gallery.RemoveAt(index);
                    this.gallery.Insert(index, s);
                    Console.WriteLine("Bạn có muốn nhập thêm ảnh? (Y/N)");
                    String yn = Console.ReadLine();
                    if (yn == "Y" || yn == "y") break;
                }
                else {
                    Console.WriteLine("Nhập ảnh mới:");
                    this.gallery.Add(Console.ReadLine());
                    Console.WriteLine("Bạn có muốn nhập thêm ảnh (Y/N)");
                    String yn = Console.ReadLine();
                    if (yn == "Y" || yn == "y") break;
                    i++;
                }
                                                  
            }
        }
        
        public void deleteImg(){
            int i = 0;
            foreach (String img in this.gallery)
            {
                Console.WriteLine(i+":"+img);            
            }
            Console.WriteLine("Chọn ảnh xóa:");
            int index = Int32.Parse(Console.ReadLine());
            this.gallery.RemoveAt(index);            
        }

        
    }
}