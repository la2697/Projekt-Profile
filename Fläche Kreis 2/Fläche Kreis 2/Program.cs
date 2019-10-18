using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fläche_Kreis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung Kreisfläche");
            Console.WriteLine("Kreisdurchmesser in mm eingeben:");
            String r = Console.ReadLine();
            double zahl = Convert.ToDouble(r);
            double ergebnis = zahl * zahl;
            double ergebnis2 = ergebnis * 0.785;
            Console.WriteLine("Ergebnis in mm^2 :" + ergebnis2);
            Console.ReadKey();
        }
    }
}
