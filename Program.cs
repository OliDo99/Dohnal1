using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dohnal_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocet,minimal, maximal;
            Console.Write("Ake velke pole: ");
            pocet = Convert.ToInt32(Console.ReadLine());
            int[] policko = new int[pocet];
            Console.Write("Min pola: ");
            minimal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max pola: ");
            maximal = Convert.ToInt32(Console.ReadLine());
            Metody.ZapisProsim(policko, minimal, maximal);
            Metody.VypisMiPoleProsim(policko);
            Metody.JeNaozajDelitelne(policko);
            Console.WriteLine(Metody.ExistujePriemer(policko));
            Console.ReadLine();
        }
        /*
         1.
            deklaracia => int[] policko
            vyhradime pamat pre pole
            vytvorenie => int[] policko = new int[pocet];
            vytvorime pole

        2.
            metody su funkcie ktore su sucastou objektu alebo tiedy
            pouzivane na ulahcenie pochopenie kodu, menej repeticie... mozeme volat funkciu viac krat
         */
    }
}
