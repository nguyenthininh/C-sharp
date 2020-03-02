using System;
using System.Collections.Generic;
using ConsoleApp1.Lap_session2;

namespace ConsoleApp1.exam
{
    public class Phone
    {
        protected string phonename;
        protected string phonetype;
        protected float phoneprice;


        public Phone()
        {
            
        }

        public Phone(string phonename, string phonetype, float phoneprice)
        {
            this.phonename = phonename;
            this.phonetype = phonetype;
            this.phoneprice = phoneprice;
        }


        public string Phonename
        {
            get => phonename;
            set => phonename = value;
        }

        public string Phonetype
        {
            get => phonetype;
            set => phonetype = value;
        }

        public float Phoneprice
        {
            get => phoneprice;
            set => phoneprice = value;
        }
        
        
        public void display()
        {
            Console.WriteLine("Phone "+Phonename+", type "+Phonetype+", price "+Phoneprice);
           
        }
        
        
    }
}