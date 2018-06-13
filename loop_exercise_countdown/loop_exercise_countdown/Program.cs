using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_exercise_countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count from 0 to 5 ");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count from 5 to 0");

            for (int a = 5; a >= 1; a--)
            {
                Console.WriteLine(a);
            }
        }
    }
}
