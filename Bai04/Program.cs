using System;
namespace Bai04
{
    class Program
    {
        static void Swap(Fraction[] array, int i, int j)
        {
            Fraction temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void SelectionSort(Fraction[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (Fraction.Compare(array[j], array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(array, i, minIndex);
                }
            }
        }
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

            int n;
            while (true)
            {
                Console.Write("Enter the number of fractions to sort: ");
                string inputN = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(inputN, out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Please enter a positive integer for N.");
            }

            Fraction[] fractions = new Fraction[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter fraction {i + 1}:");
                fractions[i] = new Fraction();
                fractions[i].Nhap();
            }

            SelectionSort(fractions);

            Console.WriteLine("\nSorted fractions");
            foreach (var frac in fractions)
            {
                Console.Write(frac + "   ");
            }
            Console.WriteLine("\n");


        }



    }
}