using System;

namespace ConsoleApp1
{
    public class Asian : Human, IHuman,IAsian
    {
        public string [] telephone = new string[5];

        public string this[int index]
        {
            get { return telephone[index]; }
            set { telephone[index] = value;  }
        }
        public override void Running()
        {
            //base.Running();  // base là đối tượng lớp cha nằm trong lớp con  base= super
            Console.WriteLine("Asian running...");
        }

        public new void Jumping()
        {
            Console.WriteLine("Asian jumping..");   //phương thức thay thế hoàn toàn pt Jumping bên Human.
        }

        public void Shopping()
        {
            
        }
        public void Drive()
        {
            
        }

        public void Parking()
        {
            
        }
    }
}