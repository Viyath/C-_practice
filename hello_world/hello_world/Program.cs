using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your date");
            var date = Console.ReadLine();

            Console.WriteLine("Enter your month");
            var month = Console.ReadLine();

            Console.WriteLine("your name is {0}" , name);
            Console.WriteLine(month);
            Console.WriteLine(date);

            if (month == "january")
            {
                Console.WriteLine("You were born in Duruthu");
            }
            else if (month == "february")
            {
                Console.WriteLine("You were born in Nawam");
            }
            else if (month == "march")
            {
                Console.WriteLine("You were born in Madin");
            }
            else
            {
                Console.WriteLine("You have born after March");
            }
        }
    }
}
