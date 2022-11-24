using System;
namespace game
{
    namespace Review
    {
        class Program
        {
            static void Main(string[] args)
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
        }
    }
}
