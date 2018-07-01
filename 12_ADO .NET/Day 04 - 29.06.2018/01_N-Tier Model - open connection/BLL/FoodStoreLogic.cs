using BOL;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class FoodStoreLogic : FoodStore
    {
        public event Action<Food> FoodSearchHandler;  //-->This is the short way (using generic delegate)

        //הקפצת אירוע בכל פעם שנמצא פריט מתאים
        public void SearchFoodByEvent()
        {
            int searchId = DbManager.UpdateDbSearch(WantedFood);
            foreach (Food item in FoodList)
            {
                if (item.FoodName.Contains(WantedFood))
                {
                    FoodSearchHandler?.Invoke(item);
                    DbManager.UpdateDbResults(searchId, item);
                }
            }
        }


        public static List<FoodSearchData> GetFoodList()
        {
            return DbManager.GetDbResults();
        }

    }
}