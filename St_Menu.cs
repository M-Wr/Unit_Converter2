namespace Unit_Converter
{
    public class Menu_St
    {
        public static void St_Conv_Menu()
        {
            Console.WriteLine("What conversion do you want to perform? Enter a number: ");
            Console.WriteLine("1. St and lbs to Kg");
            Console.WriteLine("2. Kg to St and lbs");

            var input = Console.ReadLine();
            int key = Int32.Parse(input);

            if (key == 1)
            {
                Conv2.S2Kg();

            }
            else if (key == 2)
            {
                Conv2.Kg2S();
            }
        }

    }
}
