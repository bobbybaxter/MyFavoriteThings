using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Dog
    {
        public string Breed { get; set; }
        public int Weight { get; set; }

        public void Sit()
        {
            Console.WriteLine($"The {Breed} is sitting.");
        }

        public void PlayDead()
        {
            Console.WriteLine($"The {Breed} is playing dead.");
        }

        public Dog()
        {

        }
    }
}
