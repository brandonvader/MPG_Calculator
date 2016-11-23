using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dMiles, dGallons, dDPG, dMPG;
            string sMPG;

            Console.Write("Please enter miles traveled: ");
            dMiles = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter gallons used: ");
            dGallons = Convert.ToDouble(Console.ReadLine());

            dMPG = dMiles / dGallons;
            sMPG = dMPG.ToString("##.##");

            Console.WriteLine("Your vehicle gets {0} miles to the gallon", dMPG);
            Console.WriteLine("Converted string looks like this: {0}", sMPG);

        }
    }
}
