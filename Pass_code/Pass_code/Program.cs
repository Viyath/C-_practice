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
            var Pass_code = "";
            while (username != "viyath" & Pass_code!="123")
            {
                Console.WriteLine("Please enter the username...");
                username = ReadUserInput();

                Console.WriteLine("Please enter the user password...");
                var passcode = ReadUserInput();

                if (username != "viyath")
                {
                    WriteTryAgain();
                }
                if (passcode != "123")
                {
                    WriteTryAgain();
                }                
            }
            Console.WriteLine("Successfull...");
        }
        static void WriteTryAgain()
        {
            Console.WriteLine("Invalid. Please try again.");
        }
        static string ReadUserInput()
        {
            return Console.ReadLine();
        }
    }
}
