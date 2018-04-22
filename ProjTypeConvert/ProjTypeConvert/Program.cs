using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTypeConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            if(input.All(char.IsNumber))
            {
                int number = Convert.ToInt32(input);
                number = number + 1000;
                Console.WriteLine(number);
            }

            Console.ReadKey();

        }
    }
}
