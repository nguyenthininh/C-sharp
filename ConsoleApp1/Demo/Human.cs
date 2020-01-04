using System;

namespace ConsoleApp1
{
    public class Human     //lớp
    {
        private string name;   //thuộc tính
        private int age;

        public Human()
        {
            Console.WriteLine("Constructor...");
        }

        public string Name
        {
           // get => name;
           // set => name = value;
           get { return name; }
           set { this.name = value; }
        }

        public int Age
        {
            get
            {
                if (age <= 1) return 1;
                return age;
            }
            set
            {
                if (age <= 1)
                {
                    this.age = 1;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public void SayHello()   // ham
        {
            Console.WriteLine("Hello World");
    }

        public void SayHello(string msg)  // nạp chồng nhưng khác nhau về phương thức
        {
            Console.Write("Hello " +msg);
        }

        public virtual void Running()
        {
            Console.WriteLine("Running...");
        }

        public void Jumping()
        {
            Console.WriteLine("Jumping...");
        }
        
    
    }
}