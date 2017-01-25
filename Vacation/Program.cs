using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int adultNum = int.Parse(Console.ReadLine());
            int studentNum = int.Parse(Console.ReadLine());
            int nightsNum = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double transportPrice = 0;
            double hotelPrice = nightsNum * 82.99;
            double commission = 0;
            double sum = 0;
            if (transport == "train")
            {
                transportPrice = (adultNum * 24.99 + studentNum * 14.99) * 2;
                if (adultNum + studentNum > 49)
                {
                    transportPrice /= 2;
                }
                commission = (transportPrice + hotelPrice) * 0.1;
                sum = transportPrice + hotelPrice + commission;
                Console.WriteLine("{0:F2}", sum);
            }
            else if (transport == "bus")
            {
                transportPrice = (adultNum * 32.50 + studentNum * 28.50) * 2;
                commission = (transportPrice + hotelPrice) * 0.1;
                sum = transportPrice + hotelPrice + commission;
                Console.WriteLine("{0:F2}", sum);
            }
            else if (transport == "boat")
            {
                transportPrice = (adultNum * 42.99 + studentNum * 39.99) * 2;
                commission = (transportPrice + hotelPrice) * 0.1;
                sum = transportPrice + hotelPrice + commission;
                Console.WriteLine("{0:F2}", sum);
            }
            else if (transport == "airplane") 
            {
                transportPrice = (adultNum * 70.00 + studentNum * 50.00) * 2;
                commission = (transportPrice + hotelPrice) * 0.1;
                sum = transportPrice + hotelPrice + commission;
                Console.WriteLine("{0:F2}", sum);
            }
            else
            {
                Console.WriteLine("Invalid transport!");
            }
        }
    }
}
