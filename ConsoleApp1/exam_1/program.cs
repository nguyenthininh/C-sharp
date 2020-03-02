namespace ConsoleApp1.exam
{
    public class program
    {
        static void Main(string[] args)
        {
            Phone testPhone = new Phone("Nguoi la oi","display phone",5686.2f);
            MobilePhone testMobilePhone = new MobilePhone();
            testPhone.display();
            testMobilePhone.display();
        }
    }
}