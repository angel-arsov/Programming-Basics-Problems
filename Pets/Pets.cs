using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());
            double dogFood = days * dogFoodPerDay;
            double catFood = days * catFoodPerDay;
            double turtleFood = (days * turtleFoodPerDay) / 1000;
            double totalFood = dogFood + catFood + turtleFood;
            double foodLeft = 0;
            if (totalFood <= food) 
            {
                foodLeft = food - totalFood;
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeft));
            }
            else
            {
                foodLeft = totalFood - food;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodLeft));
            }
        }
    }
}
