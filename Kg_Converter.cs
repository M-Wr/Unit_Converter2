namespace Unit_Converter
{
    public class Conv1
    {
        public static void Kg2S()
        {
            Console.WriteLine("How many kilograms do you want to convert?: ");
            var input = Console.ReadLine();
            var kilo = Int32.Parse(input);
            var stone = kilo / 6.35;
            var stoneDec = stone % 1;

            var pound = stoneDec * 14;
            stone = Math.Truncate(stone);
            pound = Math.Round(pound, 2);

            var endp = $" {kilo} Kg, is equivilent to: {stone}st and {pound}lbs";
            Console.WriteLine(endp);
        }
        public static void S2Kg()
        {
            Console.WriteLine("How many stone do you want to convert?: ");
            var input1 = Console.ReadLine();
            var stone = Int32.Parse(input1);
            Console.WriteLine("And how many pounds do you want to convert?: ");
            var input2 = Console.ReadLine();
            float pounds = Int32.Parse(input2);

            var stoneT = (pounds / 14);
            stoneT += stone;
            var kilo = stoneT * 6.35;
            kilo = Math.Round(kilo, 2);

            var endp = $"{stone}st and {pounds}lbs is equivilent to: {kilo} Kg";
            Console.WriteLine(endp);
        }
        public static void Kg2O()
        {
            Console.WriteLine("How many kilograms do you want to convert?: ");
            var input = Console.ReadLine();
            var kilo = Int32.Parse(input);
            var ounce = kilo * 35.274;
            ounce = Math.Round(ounce, 2);

            var endp = $" {kilo} Kg, is equivilent to: {ounce}oz";
            Console.WriteLine(endp);
        }
        public static void O2Kg()
        {
            Console.WriteLine("How many Ounces do you want to convert?: ");
            var input = Console.ReadLine();
            var ounce = Int32.Parse(input);
            var kilo = ounce / 35.274;
            kilo = Math.Round(kilo, 2);

            var endp = $"{ounce}Oz is equivilent to: {kilo} Kg";
            Console.WriteLine(endp);
        }
        public static void Kg2T()
        {
            Console.WriteLine("How many kilograms do you want to convert?: ");
            var input = Console.ReadLine();
            var kilo = Int32.Parse(input);
            var tonne = kilo / 1000;

            var endp = $" {kilo} Kg, is equivilent to: {tonne} Tonnes";
            Console.WriteLine(endp);
        }
        public static void T2Kg()
        {
            Console.WriteLine("How many Tonnes do you want to convert?: ");
            var input = Console.ReadLine();
            var tonne = Int32.Parse(input);
            var kilo = tonne * 1000;

            var endp = $"{tonne} Tonnes is equivilent to: {kilo} Kg";
            Console.WriteLine(endp);
        }
    }
}