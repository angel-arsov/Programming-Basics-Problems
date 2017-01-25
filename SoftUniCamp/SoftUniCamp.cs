using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int groupsNum = int.Parse(Console.ReadLine());
            int personsSum = 0;
            double car = 0;
            double microbus = 0;
            double minibus = 0;
            double bigbus = 0;
            double train = 0;
            for (int i = 0; i <= groupsNum; i++)
            {
                if (i == groupsNum) 
                {
                    Console.WriteLine("{0:F2}%", (car / personsSum * 100));
                    Console.WriteLine("{0:F2}%", (microbus / personsSum * 100));
                    Console.WriteLine("{0:F2}%", (minibus / personsSum * 100));
                    Console.WriteLine("{0:F2}%", (bigbus / personsSum * 100));
                    Console.WriteLine("{0:F2}%", (train / personsSum * 100));
                }
                else
                {
                    int personsNum = int.Parse(Console.ReadLine());
                    personsSum += personsNum;
                    if (personsNum < 6)
                    {
                        car += personsNum;
                    }
                    else if (personsNum < 13)
                    {
                        microbus += personsNum;
                    }
                    else if (personsNum < 26)
                    {
                        minibus += personsNum;
                    }
                    else if (personsNum < 41)
                    {
                        bigbus += personsNum;
                    }
                    else
                    {
                        train += personsNum;
                    }
                }
            }
        }
    }
}
