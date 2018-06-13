using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine(count);
                count++;
            }
            Console.WriteLine("for loop is starting below...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
