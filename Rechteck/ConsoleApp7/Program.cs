using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    class Funktionen
    {
        public double Querschnittflaeche(double a,double b)
        {


            double flaeche = a * b;
            return flaeche;
             
            }
        public double Volumen(double a, double b,double c)
        {


            double Volumen = a * b*c;
            return Volumen;

        }
        public double Gewicht(double a, double b, double c)
        {

            double Dicht = 2.7;
            double Gewicht = a * b * c*Dicht;
            return Gewicht;

        }
        public double FlaechentraegheitsmomentX(double a, double b)
        {

            double Flaechentraegheitsmoment = a * Math.Pow(b, 3) / 12;
            return Flaechentraegheitsmoment;
                }
        public double FlaechentraegheitsmomentY(double a, double b)
        {

            double Flaechentraegheitsmoment = b * Math.Pow(a, 3) / 12;
            return Flaechentraegheitsmoment;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Berechnung der Informations von Rechteck:");
            Console.WriteLine("Eingabe der Laenge(Einheit:cm):");
            String a = Console.ReadLine();
            double a1 = Convert.ToDouble(a);
            Console.WriteLine("Eingabe der Bereite(Einheit:cm):");
            String b = Console.ReadLine();
            double b1 = Convert.ToDouble(b);
            Console.WriteLine("Eingabe der Hoehe(Einheit:cm):");
            String c = Console.ReadLine();
            double c1 = Convert.ToDouble(c);
            Funktionen F = new Funktionen();
            Double Ersteaufgabe = F.Querschnittflaeche(a1, b1);
            Double Zeiteaufgabe = F.Volumen(a1, b1, c1);
            double Dritteaufgabe=F.Gewicht(a1, b1, c1);
            double Vierteaufgabe = F.FlaechentraegheitsmomentX(a1, b1);
            double Fuenfteeaufgabe = F.FlaechentraegheitsmomentY(a1, b1);

            Console.WriteLine("Querschnittflaeche(Einheit:cm^2): ");
            Console.WriteLine( Ersteaufgabe);
            Console.WriteLine("Volumen(Einheit:cm^3): ");
            Console.WriteLine(Zeiteaufgabe);
            Console.WriteLine("Gewicht(Einheit:g): ");
            Console.WriteLine(Dritteaufgabe);
            
            Console.WriteLine(" Flaechentraegheitsmoment fuer X-Achse(Einheit:cm^4):");
            Console.WriteLine(Vierteaufgabe);
            Console.WriteLine(" Flaechentraegheitsmoment fuer Y-Achse(Einheit:cm^4)");
            Console.WriteLine(Fuenfteeaufgabe);
            Console.ReadKey();

        }
    }
}
