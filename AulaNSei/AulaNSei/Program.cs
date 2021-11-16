using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNSei
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            //SayHi2();
            //SayHi2();
            //SayHi3();
            //SayHi3();

            Console.ReadLine();
        }
        static void SayHi()
        {
            Console.Write("Hello User");
        }
        static void SayHi2(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void SayHi3(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you're " + age);
        }
    }
}
