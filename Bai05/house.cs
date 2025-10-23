using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    public class house : immovables
    {
        public int yearbuilt { get; set; }
        public int floorsnumber { get; set; }
        public house() { }
        public override void Input()
        {
            base.Input();
            Console.Write("Enter the year built: ");
            yearbuilt = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of floors: ");
            floorsnumber = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            Console.Write("Information of house");
            base.Output();
            Console.WriteLine($"Year built: {yearbuilt}");
            Console.WriteLine($"Number of floors: {floorsnumber}");
        }

        public override double TotalPrice()
        {
            return price * area;
        }
    }
}
