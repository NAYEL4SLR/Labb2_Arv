using System;

namespace Labb2_Arv
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, Console.LargestWindowHeight);
            Eagle blackEagle = new Eagle("Rocky", "male", 8);
            Chicken redChicken = new Chicken("Ginger", "female", 3);
            Salmon salmon = new Salmon("Bubba", "male", 2);
            Goldfish goldfish = new Goldfish("Bubbles", "female", 1);
            Basil herbs = new Basil("Fluffy", "Undefined", 10);
            Spider spider = new Spider("Spidy", "male", 3);
            Human human = new Human("Mike", "male", 35);
            Dolphin dolphin = new Dolphin("Leo", "male", 25);
            Crocodile crocodile = new Crocodile("Jaws", "female", 40);

            PrintOutInfo(blackEagle);
            PrintOutInfo(redChicken);
            PrintOutInfo(salmon);
            PrintOutInfo(goldfish);
            PrintOutInfo(herbs);
            PrintOutInfo(spider);
            PrintOutInfo(human);
            PrintOutInfo(dolphin);
            PrintOutInfo(crocodile);
            
            Console.ReadLine();
        }
        static void PrintOutInfo(Animal animal)
        {
            Console.WriteLine(animal);
            Console.WriteLine(animal.DoMethods());
            Console.WriteLine("___________________________________________________");
        }
    }
}