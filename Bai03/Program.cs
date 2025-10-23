using System;

namespace Bai03
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static void Nhap(ref int m, ref int n, out int[,] a)
        {
            Console.Write("Enter number of rows (m): ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns (n): ");
            n = int.Parse(Console.ReadLine());

            a = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Enter element a[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void Xuat(int m, int n, int[,] a)
        {
            Console.WriteLine("\nMatrix Output");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void findPrime(int m, int n, int[,] a)
        {
            Console.WriteLine("\nPrime Numbers in the Matrix");
            bool foundPrime = false;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (IsPrime(a[i, j]))
                    {
                        Console.Write(a[i, j] + "\t");
                        foundPrime = true;
                    }

            if (!foundPrime)
                Console.Write("No prime numbers found.");

            Console.WriteLine();
        }

        static void findrowMaxPrime(int m, int n, int[,] a)
        {
            int index = -1;
            for (int i = 0; i < m; i++)
            {
                int primeCount = 0;
                for (int j = 0; j < n; j++)
                {
                    if (IsPrime(a[i, j]))
                        primeCount++;
                }
                if (primeCount > index)
                    index = i;
            }
            Console.WriteLine
                ($"Row with the most prime numbers is {index}");
        }
        static void findAnyNumber(int m, int n, int[,] a, int x)
        {
            bool found = false;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                    {
                        Console.WriteLine($"Position: ({i}, {j})");
                        found = true;
                    }
                }

            if (!found)
                Console.WriteLine("Number not found in the matrix.");
        }

        public static void Main(string[] args)
        {
            int m = 0;
            int n = 0;
            int[,] a;

            Nhap(ref m, ref n, out a);

            Xuat(m, n, a);
            int x = int.Parse(Console.ReadLine());
            findAnyNumber(m, n, a, x);
            
            findPrime(m, n, a);

            findrowMaxPrime(m, n, a);
        }
    }
}