namespace Unit_Converter
{
    public class conv1
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

            var endp = $"{stone}st and {pounds}lbs is equivilent to: {kilo} Kg";
            Console.WriteLine(endp);
        }
    }
}