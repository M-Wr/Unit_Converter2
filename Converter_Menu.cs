using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class Menu_converter
    {
        public static void  Main()
        {
            Console.WriteLine("What unit do you want to convert?");
            Console.WriteLine("1. Kg");
            Console.WriteLine("2. St and lbs");

            var input = Console.ReadLine();
            int key = Int32.Parse(input);

            if (key == 1)
            {
                Menu_Kg.Kg_Conv_Menu();
            }
            else if (key == 2)
            {
                Menu_St.St_Conv_Menu();
            }
            else
            {
            Console.WriteLine("Invalid input. Please start again...");
            }

        }
    }
}
