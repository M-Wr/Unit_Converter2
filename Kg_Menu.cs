using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class Menu_Kg
    {
        public static void Kg_Conv_Menu()
        {
            Console.WriteLine("What conversion do you want to perform? Enter a number: ");
            Console.WriteLine("1. Kg to St and lbs");
            Console.WriteLine("2. St and lbs to Kg");
            Console.WriteLine("3. Kg to Ounces");
            Console.WriteLine("4. Ounces to Kg");
            Console.WriteLine("5. Kg to Tonnes");
            Console.WriteLine("6. Tonnes to Kg");


            var input = Console.ReadLine();
            int key = Int32.Parse(input);


            if (key == 1)
            {
                Conv1.Kg2S();

            }
            else if (key == 2) 
            {
                Conv1.S2Kg();
            }
            else if (key == 3)
            {
                Conv1.Kg2O();
            }
            else if (key == 4)
            {
                Conv1.O2Kg();
            }
            else if (key == 5)
            {
                Conv1.Kg2T();
            }
            else if (key == 6)
            {
                Conv1.T2Kg();
            }
        }
    }
}
