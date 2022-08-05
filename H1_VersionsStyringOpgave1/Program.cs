using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_VersionsStyringOpgave1
{
    internal class Program
    {
        static string sTal1;
        static string sTal2;
        static int Velkomst()
        {
            Console.WriteLine("Velkommen til Lommeregner med Versions control");
            Console.WriteLine("Vælg først hvilken funktionalitet der ønskes.");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Minus");
            Console.WriteLine("3. Gange");
            Console.WriteLine("4. Dividere");
            Console.WriteLine("5. Udregn procent");
            Console.WriteLine("---------------------");
            Console.Write("Vælg funktion: ");
            string input = Console.ReadLine();
            int heltal = Convert.ToInt32(input);
            return heltal;
        }       //Skriver velkomst beskeden 

        static void TalBesked()
        {
            Console.WriteLine("Indtast nu de to tal der skal udføres regneopration på.\n" +
                "Tryk enter efter hvert tal.");
        }   //skriver hvad brugeren skal gøre ved indtastning af tal

        static double ReadDouble(string prompt)         //Metode til at indlæse en double fra consol input
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            double value = Convert.ToDouble(input);
            return value;
        }

        static double Plus(double tal1, double tal2)
        {
            return  tal1 + tal2;
        }

        static double Minus(double tal1, double tal2)
        {
            return tal1 - tal2;
        }

        static double Gange(double tal1, double tal2)
        {
            return tal1 * tal2;
        }

        static double Dividere(double tal1, double tal2)
        {
            return tal1 / tal2;
        }

        static double Procent(double tal1, double tal2)
        {
            return (tal1 / tal2) * 100;
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

            TalBesked();

            switch (valg)       //Vælger hvilken function brugeren har valgt
            {
                case 1:
                    resultat = Plus(ReadDouble(sTal1), ReadDouble(sTal2));
                    break;
                case 2:
                    resultat =  Minus(ReadDouble(sTal1), ReadDouble(sTal2));
                    break;
                case 3:
                    resultat =  Gange(ReadDouble(sTal1), ReadDouble(sTal2));
                    break;
                case 4:
                    resultat =  Dividere(ReadDouble(sTal1), ReadDouble(sTal2));
                    break;
                case 5:
                    resultat = Procent(ReadDouble(sTal1), ReadDouble(sTal2));
                    break;

                default:
                    break;
            }

            UdskrivResultat(resultat);
            Console.ReadLine();
        }
    }
}
