using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new int[5];
            student[0] = 10;
            student[1] = 101;
            student[2] = 102;
            student[3] = 103;
            student[4] = 310;
            Console.WriteLine(student[2]);
        }
    }
}
