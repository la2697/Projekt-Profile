using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck_Querschnitt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rechteck Querschnitt Berechnung");
            Console.WriteLine("Länge a in mm eingeben");
            String a = Console.ReadLine();
            double zahl = Convert.ToDouble(a);
            Console.WriteLine("Breite b in mm eingeben");
            String b = Console.ReadLine();
            double zahlb = Convert.ToDouble(b);

            double Ergebnis = zahl * zahlb;
            Console.WriteLine("Ergebnis in mm^2:" + Ergebnis);
            Console.ReadKey();
        }
    }
}
