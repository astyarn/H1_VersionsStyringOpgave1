using System.Net.NetworkInformation;

namespace MyOwnQuickSortAttempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antalTal = 12;                      //variabel til at bestemme størrelse af tal-array der skal sorteres
            Console.WriteLine("=== Bjørns Quick-Sort ===");

            int[] arrTal = new int[antalTal];       //Oprett array til at holde tal der skal sorteres

            Random rng = new Random();              //Ny random nummer objekt

            for (int i = 0; i < antalTal; i++)               //fylder arrayet op med random tal
            {
                arrTal[i] = rng.Next(1, 101);        //Fylder et random tal imelle 1 og 100 in i en plads på arrayet
            }

            //Skriver de autogenerede tal ud på konsollen
            Console.Write("Tal at sortere: ");
            PrintArray(arrTal);

            //Kald på quik-sort her

            //Udskriver sorteret array
            Console.Write("Det sorterede Array: ");
            PrintArray(arrTal);
        }

        private static void PrintArray(int[] arrTal)
        {
            foreach (int i in arrTal)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();                    //Linjeskift
        }
    }
}