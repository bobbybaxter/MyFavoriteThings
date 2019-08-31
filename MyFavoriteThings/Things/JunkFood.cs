using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class JunkFood
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public void MakeFood()
        {
            Console.WriteLine($"You made the {Name}.");
        }
        public void EatFood()
        {
            Console.WriteLine($"You ate the {Name}");
        }


    }
}
