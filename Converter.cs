using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    class Converter
    {
        public static void Main()
        {
            Console.WriteLine("What conversion do you want to perform? Enter a number: ");
            Console.WriteLine("1. Kg to St and lbs");
            Console.WriteLine("2. St and lbs to Kg");
            var input = Console.ReadLine();
            int key = Int32.Parse(input);


            if (key == 1)
            {
                conv1.Kg2S();

            }
            else if (key == 2) ;
            {
                conv1.S2Kg();
            }
        }
    }
}
