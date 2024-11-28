
namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fraction1 = new Fraction(3, 5); //აქ თუ მივუთითებთ ნულს მაშინ ისვრის ექსეფშენს
            var fraction2 = new Fraction(1, 2);
            Console.WriteLine(fraction1.ToString());
            Console.WriteLine(fraction2.ToString());

            var sumOfFractions = fraction1 + fraction2; //წილადების მიმატება
            Console.WriteLine(sumOfFractions.ToString());

            if (fraction1 == fraction2) //ტოლია თუ არა წილადები ერთმანეთთან
            {
                Console.WriteLine("pirveli = meores");
            }

            if (fraction1 != fraction2)
            {
                Console.WriteLine("pirveli ar udris meores");
            }
        }

    }
}