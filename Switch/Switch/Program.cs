using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your years of experience");
            var experience = int.Parse(Console.ReadLine());

            switch(experience)
            {
                case 0:
                    Console.WriteLine("you are inexperienced");
                    break;
                case 1:
                    Console.WriteLine("you are a juniour");
                    break;
                case 2:
                    Console.WriteLine("you are advanced");
                    break;
                default:
                    Console.WriteLine("you are senior");
                    break;
            }
        }
    }
}
