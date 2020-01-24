using System;
using System.Collections.Generic;
using ConsoleApp1.DelegateDemo;

namespace ConsoleApp1.Lap_session2
{
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> productList;
        private string city;
        private string country;
        
        
        public event DemoDelegate AddProduct;

        public Cart()
        {
            this.productList = new List<Product>();
        }

        public Cart(int id, string customer, double grandTotal, List<Product> productList, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.productList = productList;
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public Product this[int index]
        {
            get => productList[index];
            set => productList [index] = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }
        
        

        public Boolean addProductToCart(Product product)
        {
            if (product.CheckSoLuong())
            {
                this.productList.Add(product);
                product.Qty = product.Qty - 1;  //so luong trong kho -1
                this.grandTotal = this.grandTotal + product.price;
                return true;
            }
            return false;
        }
        
        public static void Notification(string msg)
        {
            Console.WriteLine(msg);
        }
        

        public Boolean removeProductToCart(Product product)
        {
            if (this.productList.Contains(product))
            {
                this.productList.Remove(product);
                product.qty = product.qty + 1;
                this.grandTotal = this.grandTotal - product.price;
                return true;
            }

            return false;
        }

        public double CheckOut()
        {
            if (this.city.Equals("HN") || this.city.Equals("HCM"))
            {
                return this.grandTotal * 1.01;
            }
            else if (this.city.Equals("other_city"))
        
            {
                return  this.grandTotal * 1.02;
            }
            else if (this.city.Equals("other_country"))
        
            {
                return  this.grandTotal * 1.05;
            }

            return grandTotal;
        }


    }
}