using System;
namespace Bai04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fraction a = new Fraction();
            Fraction b = new Fraction();

            Console.WriteLine("Enter two fractions to perform operations: ");
            Console.WriteLine("Enter fraction the first fraction (numerator and denominator): ");
            a.Nhap();
            Console.WriteLine("Enter fraction the second fraction (numerator and denominator): ");
            b.Nhap();

            Console.WriteLine("Sum of two fractions: " + (a + b));
            Console.WriteLine("Difference of two fractions: " + (a - b));
            Console.WriteLine("Product of two fractions: " + (a * b));
            Console.WriteLine("Quotient of two fractions: " + (a / b));



        }



    }
}