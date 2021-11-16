using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Creator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name of character: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Race: ");
            string race = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Body Type: ");
            string BType = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hair Color: ");
            string hcolor = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hair Type: ");
            string hair = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Beard Lenght:");
            string beard = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Class: ");
            int cclass = Convert.ToInt32(Console.ReadLine());
            switch ((cclass)
)
            {
                case (1):
                    Console.WriteLine();
                    Console.WriteLine($"Your character name is {name}, an {race} Warrior. ");
                    Console.WriteLine();
                    Console.WriteLine($"He has a {hair} {hcolor} hair and a {beard} beard. He's a {BType} person.");
                    Console.WriteLine();
                    Console.WriteLine("His stats are: High Defense and Damage, Low Agility and Intellect.");
                    break;
                case (2):
                    Console.WriteLine();
                    Console.WriteLine($"Your character name is {name}, an {race} Mage.");
                    Console.WriteLine();
                    Console.WriteLine($"He has a {hair} {hcolor} hair and a {beard} beard. He's a {BType} person.");
                    Console.WriteLine();
                    Console.WriteLine("His stats are: High Intellect and Damage, Medium Agility and Low Defense.");
                    break;
                case (3):
                    Console.WriteLine();
                    Console.WriteLine($"Your character name is {name}, an {race} Assassin.");
                    Console.WriteLine();
                    Console.WriteLine($"He has a {hair} {hcolor} hair and a {beard} beard. He's a {BType} person.");
                    Console.WriteLine();
                    Console.WriteLine("His stats are: High Agility, Medium Damage, Low Defense and Intellect.");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}