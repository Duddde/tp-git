using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOTO
{
    class Loto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("----------*    ****       *     **** ***** ****----------");
            Console.WriteLine("----------*    ***        *     *  *   *   *  *----------");
            Console.WriteLine("----------**** ****       ****  ****   *   ****----------\n");
            Console.WriteLine("---------------------------------------------------------\n");
            DateTime date = DateTime.Now;
            Console.WriteLine("-------------------Tirage du " + date.Day + "/" + date.Month + "/" + date.Year + "-------------------\n\n");
            int[] tabloto = new int[6];
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int number=rand.Next(1, 49);
                if (tabloto.Contains(number))
                {
                    i--;
                    continue;
                }
                tabloto[i] = number;
                Console.Write(number+"\t");
            }
            Console.ReadKey();
        }
    }
}
