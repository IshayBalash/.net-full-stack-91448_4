using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIL
{
    class Program
    {
        static void Main(string[] args)
        {


            //first food store
            FoodStoreLogic firstFoodStore = new FoodStoreLogic
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
            firstFoodStore.SearchFoodByEvent();




            //second food store
            FoodStoreLogic secondFoodStore = new FoodStoreLogic
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
            secondFoodStore.SearchFoodByEvent();


            Console.WriteLine("-------------------------show DB content-------------------------------------");
            foreach (FoodSearchData item in FoodStoreLogic.GetFoodList())
            {
                Console.WriteLine(item);
            } 
        }
    }
}
