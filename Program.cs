using System;
using KnowledgeCheck2;
using System.Collections.Generic;


namespace KnowledgeCheck2

{
    public class Program
    {
        static void Main(string[] args)
        {
            var foodLogic = new FoodLogic();
            Console.WriteLine("How many records do you want to add? ");

            var numberOfRecords = Convert.ToInt32(Console.ReadLine());

            //Fish Salmon
            var Salmon = new List<Fish>();

            //recordList.Add();

            for (int i = 0; i < numberOfRecords; i++)
            {
                var fish = new Fish();

                Console.WriteLine("What is the name of the Fish? ");
                /*string name = Console.ReadLine();
                fish.Name = name;*/
                fish.name = Console.ReadLine();


                Console.WriteLine("Which food group Do you think fish are a part of? ");
                // string foodgroup = Console.ReadLine();
                fish.foodGroup = Console.ReadLine();

                Console.WriteLine("How many minutes does it take to prep? ");
                int preptime = int.Parse(Console.ReadLine());
                fish.PrepTime = preptime;

                Console.WriteLine("How many minutes does it take to cook? ");
                int cooktime = int.Parse(Console.ReadLine());
                fish.CookTime = cooktime;

                Console.WriteLine("Is this food healthy? ");
                Console.WriteLine("Type 'yes' for yes or 'no' for no.");
                string healthbenefit = Console.ReadLine();
                fish.healthBenefit = healthbenefit;

                Console.WriteLine("Would you eat this food? ");
                Console.WriteLine("Type 'yes' for yes or 'no' for no.");
                string? desiredfood = Console.ReadLine();
                fish.desiredFood = desiredfood.ToLower();




                Salmon.Add(fish);
                Console.WriteLine(fish.ToString());
            }
        }
    }
}





// See https://aka.ms/new-console-template for more information

