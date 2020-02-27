using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSolution
{
    public class shippinginfo
    {
        public static void ShowZones()
        {
            Console.WriteLine("********************");
            Console.WriteLine("1) Zone1 ");
            Console.WriteLine("2) Zone2 ");
            Console.WriteLine("3) Zone3 ");
            Console.WriteLine("4) Zone4 ");
            Console.WriteLine("5) Exit program ");
            Console.WriteLine("********************");
        }

        public static string Zone1(int price)
        {
            return (price * 0.25).ToString();
        }
        
        public static string Zone2(int price)
        {
            double highRiskTax = 15;
            return ((price * 0.12) + highRiskTax).ToString();
        }

        public static string Zone3(int price)
        {            
            return (price * 0.8).ToString();
        }

        public static string Zone4(int price)
        {
            double highRiskTax = 15;
            return ((price * 0.4) + highRiskTax).ToString();
        }

    }
}
