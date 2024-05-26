using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine("the number 2 times the entred number equal to :" + tavan(number));
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
        public static int tavan(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return 2 * tavan(number - 1);
            }
        }
    }
}
