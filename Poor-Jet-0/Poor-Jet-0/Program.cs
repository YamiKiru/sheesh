using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poor_Jet_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 13); //Cria um nº entre 1 e 13.
            int b = rnd.Next(1, 7); //Cria um nº entre 1 e 7.
            int c = rnd.Next(52); //Cria um nº entre 0 e 52.
            Console.WriteLine(a + " " + b + " " + c);
            Console.ReadLine();
        }
    }
}
