using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte eingeben die Breite");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte eingeben die laenge");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte eingeben die Hoehe");
            double c = Convert.ToDouble(Console.ReadLine());
            double aa;
            aa = a * b * c;
            Console.WriteLine("Volumen ist {0}", aa);
            double bb;
            bb = aa * 2.7;
            Console.WriteLine("Gewicht ist {0}", bb);
            Console.ReadKey();
        }
    }
}
