using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGT
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                c = a % b;
                a = b;
                b = c;

            } while ( c != 0);
            Console.WriteLine("{0}", a);
            Console.ReadKey();





        }
    }
}
