using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Enter month: ");
        int inputMonth = int.Parse(Console.ReadLine());
        while (true)
        {
            if (!int.TryParse(inputMonth, out month) || month < 1 || month > 12 )
            {
                Console.Write("Invalid month. Please enter a month between 1 and 12: ");
                month = int.Parse(Console.ReadLine());
            }
            else break;
        }

        Console.Write("Nhập năm: ");
        int inputYear = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nMonth: {month:D2}/{year}");
        Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");

        DateTime firstDay = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);

        int startDay = (int)firstDay.DayOfWeek;

        for (int i = 0; i < startDay; i++)
            Console.Write("\t");

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(day + "\t");
            startDay++;
            if (startDay == 7)
            {
                startDay = 0;
                Console.WriteLine();
            }
        }

        Console.WriteLine("\n");
    }
}
