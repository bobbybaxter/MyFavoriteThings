using System;
using MyFavoriteThings.Things;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var dino = new Dog
            {
                Breed = "goldendoodle",
                Weight = 75,
            };

            var sweetpea = new Dog
            {
                Breed = "bichon frise",
                Weight = 11,
            };

            var kit1 = new Drums
            {
                Brand = "Gretsch",
                Pieces = 8,
            };

            var kit2 = new Drums
            {
                Brand = "Tama",
                Pieces = 4,
            };

            var guitar1 = new Guitar
            {
                Brand = "Ibanez",
                Color = "exotic wood"
            };

            var guitar2 = new Guitar
            {
                Brand = "Gibson",
                Color = "red"
            };

            var food1 = new JunkFood
            {
                Name = "pizza",
                Calories = 1200,
            };

            var food2 = new JunkFood
            {
                Name = "burger",
                Calories = 900,
            };

            Console.WriteLine($"Dino is a {dino.Breed}.");
            Console.WriteLine($"He is {dino.Weight}lbs.");
            dino.Sit();
            dino.PlayDead();

            Console.WriteLine($"Sweet Pea is a {sweetpea.Breed}.");
            Console.WriteLine($"She is {sweetpea.Weight}lbs.");
            sweetpea.Sit();
            sweetpea.PlayDead();

            Console.WriteLine($"This is my {kit1.Pieces} piece {kit1.Brand} kit.");
            kit1.Tune();
            kit1.Play();

            Console.WriteLine($"This is my {kit2.Pieces} piece {kit1.Brand} kit.");
            kit2.Tune();
            kit2.Play();

            Console.WriteLine($"This is my {guitar1.Color} {guitar1.Brand} guitar.");
            guitar1.Tune();
            guitar1.Shred();

            Console.WriteLine($"This is my {guitar2.Color} {guitar2.Brand} guitar.");
            guitar2.Tune();
            guitar2.Shred();

            Console.WriteLine($"I'm going to make a {food1.Calories} calorie {food1.Name}");
            food1.MakeFood();
            food1.EatFood();

            Console.WriteLine($"I'm going to make a {food2.Calories} calorie {food2.Name}");
            food2.MakeFood();
            food2.EatFood();

            Console.ReadLine();
        }
    }
}
