using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zylinder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte eingeben das Radius");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte eingeben die laenge");
            double b = Convert.ToDouble(Console.ReadLine());
            double aa;
            aa = 3.14159265*a*a*b;
            Console.WriteLine("Volumen ist {0}", aa);
            double bb;
            bb = aa * 2.7;
            Console.WriteLine("Gewicht ist {0}", bb);
            Console.ReadKey();
        }
    }
}
