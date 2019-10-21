using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächentägheitsmoment_für_Rechteck
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Berechnung der Flaechentaegheitsmoment fuer Rechteck :");
            Console.WriteLine("Eingabe der Laenge:");
            String Laenge = Console.ReadLine( ); 
            Double a = Convert.ToDouble(Laenge);
            Console.WriteLine("Eingabe der Breite:");
            String Breite = Console.ReadLine();
            Double b = Convert.ToDouble(Breite);
            double Flächenträgheitsmoment  = a * Math.Pow(b, 3)/12;
            Console.WriteLine("Ausgabe des Flaechentraegheitsmoments fuer x-Achse:");
            Console.WriteLine(Flächenträgheitsmoment );
            double Flächenträgheitsmoment2 = b * Math.Pow(a, 3) / 12;
            Console.WriteLine("Ausgabe des Flaechentraegheitsmoments fuer y-Achse:");
            Console.WriteLine(Flächenträgheitsmoment2);
        }
    }
}
