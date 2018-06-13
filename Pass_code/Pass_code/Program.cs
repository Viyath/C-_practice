using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_code
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "";
            while (username != "viyath")
            {
                Console.WriteLine("Please enter the username...");
                username = Console.ReadLine();

                Console.WriteLine("Please enter the user password...");
                var passcode = Console.ReadLine();

                if (username == "viyath")
                {
                    Console.WriteLine("User is identified");
                }
                else if (username != "viyath")
                {
                    Console.WriteLine("Unknown user!");
                }
                if (passcode == "123")
                {
                    Console.WriteLine("Success password!");
                }
                else
                {
                    Console.WriteLine("Error in Passcode");
                }
            }
        }
    }
}
