﻿using System;
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

                default:
                    break;
            }
            
            UdskrivResultat(resultat);
            Console.ReadLine();
            //hey hvordan har du det?
        }
    }
}
