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
            int x = arrTal.Length - 1;
            QuickSort(arrTal, 0, x);

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

        public static void QuickSort(int[] arr, int lowIndx, int highIndx )
        {
            if (lowIndx < highIndx)     //tjek om der mere end et tal i array'et
            {
                //Find pivot index
                int pivotIndx = OpdelArray(arr, lowIndx, highIndx);

                //Udfør quicksort på de to dele (hvis de eksisterer)
                QuickSort(arr, lowIndx, pivotIndx - 1);
                QuickSort(arr, pivotIndx + 1, highIndx);
            }
        }

        public static int OpdelArray(int[] arr, int lowIndx, int highIndx)
        {
            //fastlæg pivot strategi
            int pivotVærdi = arr[highIndx];

            //tælle vriable
            int i = (lowIndx - 1);

            for (int j = lowIndx; j < highIndx; j++)
            {
                if (arr[j] < pivotVærdi)
                {
                    i++;
                    SwapPlaces(arr, i, j);
                }
            }
            SwapPlaces(arr, i + 1, highIndx);
            return (i + 1);
        }

        static void SwapPlaces(int[] arr, int i, int j)        
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
    }
}