using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = { 2.02, 4.32, 0.44, 5.83, 1.2, -2.6 };
            Console.WriteLine("Values Ceiling Floor\n");
            foreach (double value in values)
                Console.WriteLine("{0,4} {1,1} {2,32}", value, Math.Ceiling(value), Math.Floor(value)); 
            /* Ceiling retorna o menor valor integral que é maior ou igual à variavel double. 
             * Floor retorna o maior valor integral que é menor ou igual à variavel double */
            Console.WriteLine();

            int var1 = 2;
            int var2 = 6;
            long longresult;

            longresult = Math.BigMul(var1, var2);
            // BigMul produz o produto máximo de 2 numeros de 32-bits.
            Console.WriteLine("{0} * {1} = {2}", var1, var2, longresult);
            Console.WriteLine();

            string f1 = "yeet";
            string f2 = "yaah";
            string f3 = "yaah";
            string f4 = "beet";
            Console.WriteLine(string.Compare(f1, f2)); //f1 > f2 retorna 1.
            Console.WriteLine(string.Compare(f2, f3)); //f2 == f3 retorna 0.
            Console.WriteLine(string.Compare(f4, f1)); //f4 < f1 retorna -1.

            Console.Write("Escreva uma cor: ");
            string cor = Console.ReadLine();
            Console.Write("Escreva uma parte de uma roupa: ");
            string roupa = Console.ReadLine();
            Console.Write("Escreva um nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"{nome} tinha uma {roupa} em que a cor era {cor}."); //Usar o sinal "$" antes das aspas faz com que possamos usar "{}" para inserir as variaveis.
            Console.WriteLine();

            string breh = "I don't";
            string bruh = breh.Trim();
            Console.WriteLine(bruh);

            Console.ReadLine();
        }
    }
}
