using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSolution
{

    public delegate string ZoneDelegate(int arg1);
    class Program
    {


        static void Main(string[] args)
        {
            shippinginfo shippinginfo = new shippinginfo();
            while (true)
            {

                // ask user for destination
                Console.WriteLine("Which zone do you wish to send item?");
                shippinginfo.ShowZones();
                string zoneChoice = Console.ReadLine();
                Console.WriteLine();

                // Exit out of the program if choice is 5
                if (zoneChoice == "5")
                {
                    System.Environment.Exit(1);
                }

                // ask user for price of item
                Console.WriteLine("What is the price of the item you wish to send?");
                int price = int.Parse(Console.ReadLine());

                // show user tax for that item in that zone

                ZoneDelegate z = shippinginfo.Zone1;

                switch (zoneChoice)
                {
                    case "1":
                        z = shippinginfo.Zone1;
                        ShowTax("zone1", z(price));
                        break;
                    case "2":                    
                        z = shippinginfo.Zone2;
                        ShowTax("zone2", z(price));
                        break;
                    case "3":
                        z = shippinginfo.Zone3;
                        ShowTax("zone3", z(price));
                        break;
                    case "4":
                        z = shippinginfo.Zone4;
                        ShowTax("zone4", z(price));
                        break;
                    default:
                        break;
                }

            }


        }
        private static void ShowTax(string zone, string tax)
        {
            Console.WriteLine($"The tax for {zone} is: {tax}");
            Console.WriteLine("Press Enter to return to zone selection");
            Console.ReadKey();
            Console.Clear(); 
        }
    }
}
