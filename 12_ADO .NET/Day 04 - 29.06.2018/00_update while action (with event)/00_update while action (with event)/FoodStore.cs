using System;
using System.Collections.Generic;

namespace _00_update_while_action__with_event_
{

    delegate void FoodSearcher(Food food);

    class FoodStore
    {
        public List<Food> FoodList { get; set; }

        public string WantedFood { get; set; }


        //public event FoodSearcher FoodSearchHandler;  //-->This is the long way
        public event Action<Food> FoodSearchHandler;  //-->This is the short way (using generic delegate)


        //הקפצת אירוע בכל פעם שנמצא פריט מתאים
        public void SearchFoodByEvernt()
        {
           int searchId= DbManager.UpdateDbSearch(WantedFood);
            foreach (Food item in FoodList)
            {
                if (item.FoodName.Contains(WantedFood))
                {
                    FoodSearchHandler?.Invoke(item);
                    DbManager.UpdateDbResults(searchId, item);
                }
            }
        }



        //בדיקת כל הפריטים והחזרה של המתאימים בצורה מרוכזת
        public List<Food> SearchFood()
        {
            List<Food> foodRes = new List<Food>();
            foreach (Food item in FoodList)
            {
                if (item.FoodName.Contains(WantedFood))
                {
                    foodRes.Add(item);
                }
            }
            return foodRes;
        }
    }
}
