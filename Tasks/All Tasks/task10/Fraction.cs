
namespace task10
{
    public class Fraction
    {
        private int _numerator; // მრიცხველი
        private int _denominator; //მნიშვნელი

        public Fraction(int numerator, int denominator) //კონსტრუქტორის მომზადება
        {
            if (denominator == 0)
                throw new DivideByZeroException();

            _numerator = numerator;
            _denominator = denominator;
        }

        public override string ToString()  //თუ სტრინგ მეთოდის გადატვირთვა

        {
            return $"{_numerator}/{_denominator}";
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2) // მიმატების ოპერატორის გადატვირთვა
        {
            if (fraction1._denominator == fraction2._denominator)
            {
                return new Fraction(fraction1._numerator + fraction2._numerator, fraction1._denominator);
            }

            else
            {
                int denominator = LCM(fraction1._denominator, fraction2._denominator);
                int numerator = (denominator / fraction1._denominator * fraction1._numerator) + (denominator / fraction2._denominator * fraction2._numerator);
                int gcd = GCD(numerator, denominator);
                return new Fraction(numerator / gcd, denominator / gcd);

            }
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        public static bool operator ==(Fraction fraction1, Fraction fraction2) //შედარების ოპერატორის გადატვირთვა
        {
            return (fraction1._numerator == fraction2._numerator && fraction1._denominator == fraction2._denominator);
        }

        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            return !(fraction1 == fraction2);
        }
    }

}
