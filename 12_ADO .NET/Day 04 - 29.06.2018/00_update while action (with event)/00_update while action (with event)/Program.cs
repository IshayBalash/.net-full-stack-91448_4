using System;
using System.Collections.Generic;

namespace _00_update_while_action__with_event_
{
    class Program
    {
        static void Main(string[] args)
        {

            //first food store
            FoodStore firstFoodStore = new FoodStore
            {
                FoodList = new List<Food>{
                new Food {Price=24,FoodName="Pizza", IsVeg=false },
                new Food {Price=22,FoodName="Chips", IsVeg=true },
                new Food {Price=56,FoodName="Salad", IsVeg=true },
                new Food {Price=9,FoodName="Water", IsVeg=true }
            },
                WantedFood = "a"
            };

            firstFoodStore.FoodSearchHandler += (food) => { Console.WriteLine($"firstFoodStore got: {food.FoodName}"); };
            firstFoodStore.SearchFoodByEvernt();




            //second food store
            FoodStore secondFoodStore = new FoodStore
            {
                FoodList = new List<Food>{
                new Food {Price=24,FoodName="Pizza", IsVeg=false },
                new Food {Price=22,FoodName="Chips", IsVeg=true },
                new Food {Price=56,FoodName="Salad", IsVeg=true },
                new Food {Price=9,FoodName="Water", IsVeg=true }
            },
                WantedFood = "P"
            };

            secondFoodStore.FoodSearchHandler += (food) => { Console.WriteLine($"secondFoodStore got: {food.FoodName}"); };
            secondFoodStore.SearchFoodByEvernt();


            Console.WriteLine("-------------------------show DB content-------------------------------------");
            DbManager.ShowDbResults();
        }
    }
}


/*
 OUTPUT:
 __________________________________
 
     
firstFoodStore got: Pizza
firstFoodStore got: Salad
firstFoodStore got: Water
secondFoodStore got: Pizza
-------------------------show DB content-------------------------------------
FoodName: Pizza, Price: 24, IsVeg: False, SearchQuery: a
FoodName: Salad, Price: 56, IsVeg: True, SearchQuery: a
FoodName: Water, Price: 9, IsVeg: True, SearchQuery: a
FoodName: Pizza, Price: 24, IsVeg: False, SearchQuery: P

 */
