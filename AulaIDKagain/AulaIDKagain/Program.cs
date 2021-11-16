using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaIDKagain
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cubedNumber = cube2(6);
            //Console.WriteLine(cubedNumber);
            Console.WriteLine(cube(5));
            Console.ReadLine();
        }
        static int cube(int num)
        {
            int result = num + num + num;
            return result;
        }
        /*static int cube2(int num)
        {
            int result = num + num + num;
            return result;
        }*/
    }
}
