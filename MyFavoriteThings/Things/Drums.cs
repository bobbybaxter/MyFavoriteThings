using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Drums
    {
        public string Brand { get; set; }
        public int Pieces { get; set; }

        public void Play()
        {
            Console.WriteLine($"You are playing the {Brand} kit.");
        }

        public void Tune()
        {
            Console.WriteLine($"You tuned the {Brand} kit.");
        }
    }
}
