using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckynumbers = { 4, 2, 5, 7, 9, 17 };
            string[] player = new string[5]; //guarda 5 valores.

            Console.WriteLine(luckynumbers[0]);

            luckynumbers[1] = 900;

            Console.WriteLine(luckynumbers[1]);

            player[0] = "Kiru";
            player[1] = "Kira";
            player[2] = "Kiro";
            player[3] = "Kiri";
            player[4] = "Kire";

            Console.WriteLine(player[4]);

            Console.ReadLine();
        }
    }
}
