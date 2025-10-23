using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    public abstract class immovables
    {
        public string address { get; set; }
        public double price { get; set; }
        public double area { get; set; }
        public virtual int Yearbuilt 
        { 
            get { return 0; } 
        }

        public immovables() { }
        public immovables(string address, double price, double area)
        {
            this.address = address;
            this.price = price;
            this.area = area;
        }
        public virtual void Input()
        {
            Console.Write("Enter the address: ");
            address = Console.ReadLine();
            Console.Write("Enter the price per square meter: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Enter the area (m2): ");
            area = double.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Area: {area}");
        }

        public virtual double TotalPrice()
        {
            return price * area; 
        }

        
    }
}
