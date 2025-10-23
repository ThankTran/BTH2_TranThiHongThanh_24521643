using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    public class apartment : immovables
    {
        public int floor { get; set; }
        public apartment() { }
        public override void Input()
        {
            base.Input();
            Console.Write("Enter the floor: ");
            floor = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.Write("Information of apartment");
            Console.WriteLine($"Floor: {floor}");
        }

        public override double TotalPrice()
        {
            return price * area; 
        }
    }
}
