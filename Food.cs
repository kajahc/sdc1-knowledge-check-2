using System;



namespace KnowledgeCheck2
{
    public class Food
    {    //properties
        public string? name { get; set; }
        public string? foodGroup { get; set; }
        public string? healthBenefit { get; set; }
        public string? desiredFood { get; set; }

        public Food(string? Name, string? Group, string? Healthy, string? Wanted)
        {
            name = Name;
            foodGroup = Group;
            healthBenefit = Healthy;
            desiredFood = Wanted;
        }


    }

    public class Fish : Food
    {
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public Fish(int PrepTime, int CookTime);




    }
}
public Fish(string? Name, string? Group, string? Healthy, string? Wanted) : base(Name, Group, Healthy, Wanted)
        {
}

        

    }


    class FoodLogic
{
    private List<Food> _foods;

    public FoodLogic()
    {
        _foods = new List<Food>();
    }

    public void AddFood(Food food)
    {
        _foods.Add(food);
    }

    /*public List<Food> GetAllFoods()
    {
        return _foods;
    }*/
}
    //Console.WriteLine(JsonSerializer.Serialize());// serialize objects
}
