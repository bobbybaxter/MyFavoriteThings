using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Guitar
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public void Tune()
        {
            Console.WriteLine($"You tuned the {Brand} guitar.");
        }

        public void Shred()
        {
            Console.WriteLine($"You're shredding on the {Brand} guitar");
        }
    }
}
