using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_VersionsStyringOpgave1
{
    internal class Program
    {
        static int Velkomst()
        {
            Console.WriteLine("Velkommen til Lommeregner med Versions control");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Minus");
            Console.WriteLine("3. Gange");
            Console.WriteLine("4. Dividere");
            Console.WriteLine("---------------------");
            Console.Write("Vælg funktion: ");
            string input = Console.ReadLine();
            int heltal = Convert.ToInt32(input);
            return heltal;
        }

        static double Plus()
        {
            return 0;
        }

        static double Minus()
        {
            return 0;
        }

        static double Gange()
        {
            return 0;
        }

        static double Dividere()
        {
            return 0;
        }

        static void UdskrivResultat(double temp)
        {
            Console.WriteLine("---------------------");
            Console.Write("Resultat: ");
            Console.WriteLine(temp);
            Console.WriteLine("---------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int valg = Velkomst();

            double resultat = 0;

            switch (valg)
            {
                case 1:
                    resultat = Plus();
                    break;
                case 2:
                    resultat =  Minus();
                    break;
                case 3:
                    resultat =  Gange();
                    break;
                case 4:
                    resultat =  Dividere();
                    break;

                default:
                    break;
            }

            UdskrivResultat(resultat);
        }
    }
}
