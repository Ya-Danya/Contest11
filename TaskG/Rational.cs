using System;

public class Rational
{
    int numerator;
    int denomenator;

    public Rational(int num, int den)
    {
        numerator = num;
        denomenator = den;
    }
    public static Rational Parse(string input)
    {
        if (input.Contains('/'))
        {
            string[] args = input.Split('/');
            return new Rational(int.Parse(args[0]), int.Parse(args[1]));
        }
        else
        {
            return new Rational(int.Parse(input), 1);
        }
    }
    static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

    public static Rational operator +(Rational r1, Rational r2)
    {
        int den = r1.denomenator * r2.denomenator;
        int num = r1.numerator * r2.denomenator + r2.numerator * r1.denomenator;
        int gcd = GreatestCommonDivisor(num, den);
        if (den < 0)
        {
            num *= -1;
            den *= -1;
        }
        return new Rational(num / gcd, den / gcd);
    }
    public static Rational operator -(Rational r1, Rational r2)
    {
        int den = r1.denomenator * r2.denomenator;
        int num = r1.numerator * r2.denomenator - r2.numerator * r1.denomenator;
        int gcd = GreatestCommonDivisor(num, den);
        if (den < 0)
        {
            num *= -1;
            den *= -1;
        }
        return new Rational(num / gcd, den / gcd);
    }
    public static Rational operator /(Rational r1, Rational r2)
    {
        Rational rational = Swap(r2);
        return r1 * rational;
    }
    static Rational Swap(Rational rational)
    {
        return new Rational(rational.denomenator, rational.numerator);
    }
    public static Rational operator *(Rational r1, Rational r2)
    {
        int num = r1.numerator * r2.numerator;
        int den = r1.denomenator * r2.denomenator;
        int gcd = GreatestCommonDivisor(num, den);
        if (den < 0)
        {
            num *= -1;
            den *= -1;
        }
        return new Rational(num / gcd, den / gcd);
    }
    public override string ToString()
    {
        if (denomenator == 1)
            return numerator.ToString();
        return numerator + "/" + denomenator;
    }
}