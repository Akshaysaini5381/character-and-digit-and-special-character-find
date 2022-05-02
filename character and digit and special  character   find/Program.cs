using System;

namespace character_and_digit_and_special__character___find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value :-");
            char data = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(" This is  value ({0}) ",data);

            if (data >= 65 && data <= 90 || data >= 97 && data <= 122)
                Console.WriteLine("This is a Alphabat");
            else if (data >= 48 && data <= 57)
                Console.WriteLine("This is a Digit");
            else
                Console.WriteLine("Special character");
            Console.ReadLine();
        }
       
    }
}
