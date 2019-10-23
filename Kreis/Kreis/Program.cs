using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreis
{
    class Funktionen

    {
        public double Querschnittflaeche(double a)
        {


            double flaeche = 0.25*3.1415926*Math.Pow(a,2);
            return flaeche;

        }
        public double Volumen(double a,  double c)
        {


            double Volumen = 0.25 * 3.1415926 * Math.Pow(a, 2)*c;
            return Volumen;

        }
        public double Gewicht(double a,  double c)
        {

            double Dicht = 2.7;
            double Gewicht = 0.25 * 3.1415926 * Math.Pow(a, 2) * c * Dicht;
            return Gewicht;

        }
        public double Flaechentraegheitsmoment(double a)
        {
            double Pi = 3.1415926;
            double Flaechentraegheitsmoment = Pi * Math.Pow(a, 4) / 64;
            return Flaechentraegheitsmoment;
        }
       




        static void Main(string[] args)
        {

            Console.WriteLine("Berechnung der Informations von Kreis:");
            Console.WriteLine("Eingabe des Durchmessers(Einheit:cm):");
            String a = Console.ReadLine();
            double a1 = Convert.ToDouble(a);
           
            Console.WriteLine("Eingabe der Hoehe(Einheit:cm):");
            String c = Console.ReadLine();
            double c1 = Convert.ToDouble(c);
            Funktionen F = new Funktionen();
            Double Ersteaufgabe = F.Querschnittflaeche(a1);
            Double Zeiteaufgabe = F.Volumen(a1,  c1);
            double Dritteaufgabe = F.Gewicht(a1, c1);
            double Vierteaufgabe = F.Flaechentraegheitsmoment(a1 );
            

            Console.WriteLine("Querschnittflaeche(Einheit:cm^2): ");
            Console.WriteLine(Ersteaufgabe);
            Console.WriteLine("Volumen(Einheit:cm^3): ");
            Console.WriteLine(Zeiteaufgabe);
            Console.WriteLine("Gewicht(Einheit:g): ");
            Console.WriteLine(Dritteaufgabe);

            Console.WriteLine("Ausgabe des Flaechentraegheitsmoments(Flaechentraegheitsmoment ist fuer X-Achse und Y-Achse gleich)(Einheit:cm^4）:");
            Console.WriteLine(Vierteaufgabe);
           
           
            Console.ReadKey();
        }
    }
}
