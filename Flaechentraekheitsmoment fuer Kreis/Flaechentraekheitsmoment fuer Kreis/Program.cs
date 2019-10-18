using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächenträgheitsmoment_fuer_Kreis
{  
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Berechnung der Flaechentraegheitsmoment fuer Kreis:");
            Console.WriteLine("Eingabe des Durchmesers:");
            String Durchmesser = Console.ReadLine();
            Double b = Convert.ToDouble(Durchmesser);
            double Pi = 3.1415926;
            double Flächenträgheitsmoment = (float)Pi * Math.Pow(b, 4) / 64;
            Console.WriteLine("Ausgabe des Flaechentraegheitsmoments(Flaechentraegheitsmoment ist fuer X-Achse und Y-Achse gleich):");
            Console.WriteLine(Flächenträgheitsmoment);

           


        }
    }
}
