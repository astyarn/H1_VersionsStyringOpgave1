using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_VersionsStyringOpgave1
{
    internal class Program
    {
        /*
         * Programmet er en lille consol lommeregner, der tillader en bruger at udføre 5 små regneoperationer
         * plus, minus, gange, divider og procent regning.
         * Input er igennem consol vinduet
         * Output kommer som tekst på consolvinduet
         */

        //strings til at gemme input fra user af de tal der bruges til regneoperation
        static string sTal1;
        static string sTal2;
        static int Velkomst()   //Skriver velkomst beskeden til consol 
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
        }       

        static void TalBesked() //Skriver info om tal input til consol
        {
            Console.WriteLine("Indtast nu de to tal der skal udføres regneopration på.\n" +
                "Tryk enter efter hvert tal.");
        }  

        static double ReadDouble(string prompt)  //Metode til at omregne string til double
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            double value = Convert.ToDouble(input);
            return value;
        }

        static double Plus(double tal1, double tal2) //Lægger to tal sammen 
        {
            return  tal1 + tal2;
        }

        static double Minus(double tal1, double tal2) //Trækker to tal fra hinanden
        {
            return tal1 - tal2;
        }

        static double Gange(double tal1, double tal2) //Ganger to tal med hinanden
        {
            return tal1 * tal2;
        }

        static double Dividere(double tal1, double tal2) //Dividerer to tal
        {
            return tal1 / tal2;
        }

        static double Procent(double tal1, double tal2) //Udregner hvor mange procent tal1 er af tal2
        {
            return (tal1 / tal2) * 100;
        }

        static void UdskrivResultat(double temp) //Udskriver resultat tekst og indsætter det udregnede resultat
        {
            Console.WriteLine("---------------------");
            Console.Write("Resultat: ");
            Console.WriteLine(temp);
            Console.WriteLine("---------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int valg = Velkomst();  //Skriver velkomst og modtager bruger input

            double resultat = 0;    //Opretter variable til at gemme resultatet

            TalBesked();            

            //Vælger hvilken function brugeren har valgt
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
                case 5:
                    resultat = Procent(ReadDouble(sTal1), ReadDouble(sTal2));
                    break;

                default:
                    break;
            }

            UdskrivResultat(resultat);  //Udskriver resultatet med tekst

            Console.ReadLine();     //Holder consolvinduet åbent indtil der trykker en vilkårlig taste 
        }
    }
}
