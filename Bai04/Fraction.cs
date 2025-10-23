
using System;
using System.Numerics;

namespace Bai04
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;
        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
            Simplify();
        }

        private void Simplify()
        {
            int gcd = GreatestCommonDivisor(_numerator, _denominator);
            _numerator /= gcd;
            _denominator /= gcd;
            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        public void Nhap()
        {

            while (true)
            {
                try
                {
                    Console.Write("Enter the numerator: ");
                    _numerator = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Numerator must be a number. Please enter again.");
                    continue;
                }
                break;
            }


            while (true)
            {
                try
                {
                    Console.Write("Enter the denomiator: ");
                    int _denominator;
                    _denominator = int.Parse(Console.ReadLine()!);
                    if (_denominator == 0)
                    {
                        Console.WriteLine("Error! Denominator cannot be zero. Please enter again.");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Denominator must be a number. Please enter again.");
                }
            }
            //break;


            Simplify();
        }
        private static int GreatestCommonDivisor(int a, int b)
        {
            return Math.Abs((int)BigInteger.GreatestCommonDivisor(a, b));
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a._numerator * b._denominator + b._numerator * a._denominator;
            int denominator = a._denominator * b._denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a._numerator * b._denominator - b._numerator * a._denominator;
            int denominator = a._denominator * b._denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a._numerator * b._numerator;
            int denominator = a._denominator * b._denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("Cannot divide by a number of dials with zero");
            int numerator = a._numerator * b._denominator;
            int denominator = a._denominator * b._numerator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }
}