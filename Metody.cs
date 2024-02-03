using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dohnal_1
{
    class Metody
    {
        public static void VypisMiPoleProsim(int[] policko)
        {
            Console.Write("Cisla pola su: ");
            for (int x = 0; x < policko.Length; x++) // prejde cez pole
            {
                Console.Write(policko[x] + ", "); // vypise pole
            }
            Console.WriteLine();
        }
        public static int[] ZapisProsim(int[] policko, int minimal, int maximal)
        {
            Random rand = new Random(); //random cila
            int num;
            for (int x = 0; x < policko.Length; x++)
            {
                num = rand.Next(minimal, maximal+1); // random hodnota
                if (num % 2 == 0) // ak je parne
                {
                    policko[x] = num; // zapise
                }
                else
                {
                    x--; // skusi znova
                }

            }
            return policko; // vrati pole
        }
        public static void JeNaozajDelitelne(int[] policko)
        {
            Console.Write("Cisla delitelne 4 a 8 su: ");
            for (int x = 0; x < policko.Length; x++)
            {
                if (policko[x] % 4 == 0 && policko[x] % 8 == 0) // ci je delitelne 4 a 8
                {
                    Console.Write(policko[x] + ", "); // vypise
                }
            }
            Console.WriteLine(); // prehladnost
        }
        public static double ExistujePriemer(int[] policko)
        {
            Console.Write("Priemer prvkou s neparnym indexom je: ");
            double pocetPrvkou = 0, sucet = 0;
            for (int x = 0; x < policko.Length; x++)
            {
                if (x % 2 != 0) // neparne indexy
                {
                    pocetPrvkou++;
                    sucet += policko[x];
                }
            }
            return sucet / pocetPrvkou; // avg
        }
        public static int[] ZapisProsim(int minimal, int maximal, int[] policko) // zmenene poradie na pretezenie funckie
        {
            Random rand = new Random();
            int y;
            for (int x = 0; x < policko.Length; x++)
            {
                y = rand.Next(minimal, maximal);
                if (y % 2 == 0)
                {
                    policko[x] = y;
                }
                else
                {
                    x--;
                }

            }
            return policko;
        }
    }
}
