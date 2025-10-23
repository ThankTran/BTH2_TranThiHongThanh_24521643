using System;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            company company = new company();

            Console.WriteLine("=== Immovable Management System ===");
            company.Input();
            company.Output();

            Console.WriteLine($"\nTotal Price of all Immovables: " +
                $"{company.TotalPrice():C}");

            company.SearchByArea();

            company.SearchByCriteria();
        }
    }
}