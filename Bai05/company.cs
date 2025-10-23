using System;
using System.Collections.Generic;

namespace Bai05
{
    public class company
    {
        private List<immovables> im = new List<immovables>();

        public void Input()
        {
            Console.Write("Enter the number of immovables: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter the type of immovable (1: land, 2: house, 3: apartment): ");
                int type = int.Parse(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        land l = new land();
                        l.Input();
                        im.Add(l);
                        break;
                    case 2:
                        house h = new house();
                        h.Input();
                        im.Add(h);
                        break;
                    case 3:
                        apartment a = new apartment();
                        a.Input();
                        im.Add(a);
                        break;
                    default:
                        Console.WriteLine("Invalid type.");
                        break;
                }
            }
        }

        public void Output()
        {
            Console.WriteLine("\n=== List of immovables ===");
            foreach (var x in im)
                x.Output();
        }

        public double TotalPrice()
        {
            double total = 0;
            foreach (var immovable in im)
            {
                total += immovable.TotalPrice();
            }
            return total;
        }

        public void SearchByArea()
        {
            Console.WriteLine("\nList of land with area greater than 100m2 or house with area greater than 60m2 and yearbuilt >=2019: ");
            foreach (var x in im)
            {
                if ((x is land && x.area > 100) || (x is house && x.area > 60 && x.Yearbuilt >= 2019))
                {
                    x.Output();
                }
            }
        }

        public void SearchByCriteria()
        {
            Console.WriteLine("\n=== Search House or Apartment by Criteria ===");
            Console.Write("Enter search address (partial match): ");
            string searchAddress = Console.ReadLine().Trim();

            Console.Write("Enter maximum total price (VND): ");
            if (!double.TryParse(Console.ReadLine(), out double maxPrice))
            {
                Console.WriteLine("Invalid price entered. Setting max price to 0.");
                maxPrice = 0;
            }

            Console.Write("Enter minimum area (m2): ");
            if (!double.TryParse(Console.ReadLine(), out double minArea))
            {
                Console.WriteLine("Invalid area entered. Setting min area to 0.");
                minArea = 0;
            }

            string searchAddressLower = searchAddress.ToLower();
            bool found = false;

            foreach (var x in im)
            {
                if (x is house || x is apartment)
                {
                    bool addressMatch = string.IsNullOrEmpty(searchAddress) ||
                                        x.address.ToLower().Contains(searchAddressLower);

                    bool priceMatch = maxPrice <= 0 || x.TotalPrice() <= maxPrice;

                    bool areaMatch = x.area >= minArea;

                    if (addressMatch && priceMatch && areaMatch)
                    {
                        x.Output();
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No House or Apartment found matching the criteria.");
            }
        }
    }
}
