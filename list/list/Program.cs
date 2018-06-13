using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>();
            var age = new List<int>();
            var condition = true;
            while (condition)
            {
                Console.WriteLine("Please enter the name ");
                name.Add(Console.ReadLine());

                Console.WriteLine("Please enter the age ");
                age.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Do you want to continue? y/n");
                
                if (Console.ReadLine() != "y")
                {
                    condition = false;
                }

            }

        }
    }
}
