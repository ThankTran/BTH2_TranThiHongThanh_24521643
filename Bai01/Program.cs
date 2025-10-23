using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int month;
        int year;

        while (true)
        {
            Console.Write("Enter month (1-12): ");
            string inputMonth = Console.ReadLine();

            if (int.TryParse(inputMonth, out month) && month >= 1 && month <= 12)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid month. Please enter a month between 1 and 12.");
            }
        }

        while (true)
        {
            Console.Write("Enter year: ");
            string inputYear = Console.ReadLine();

            if (int.TryParse(inputYear, out year) && year > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid year. Please enter a valid year (e.g., 2025).");
            }
        }

        Console.WriteLine($"\nMonth: {month:D2}/{year}");
        Console.WriteLine();
        Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
        

        DateTime firstDay = new DateTime(year, month, 1);

        int daysInMonth = DateTime.DaysInMonth(year, month);

        int startDayOfWeek = (int)firstDay.DayOfWeek;

        for (int i = 0; i < startDayOfWeek; i++)
            Console.Write("\t");

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(day + "\t");

            startDayOfWeek++;

            if (startDayOfWeek == 7)
            {
                startDayOfWeek = 0;
                Console.WriteLine();
            }
        }

        Console.WriteLine("\n");
    }
}