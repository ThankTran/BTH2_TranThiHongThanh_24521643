using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    public class land : immovables
    {
        public land() { }
        public override void Output()
        {
            Console.Write("Information of land");
            base.Output();
        }

        public override double TotalPrice()
        {
            return price * area;
        }

        


       
    }
}
