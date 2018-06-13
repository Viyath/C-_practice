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
        }
    }
}
