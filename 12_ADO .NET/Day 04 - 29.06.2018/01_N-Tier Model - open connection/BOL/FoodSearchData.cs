// BOL - Bussines object layer
namespace BOL
{
    public class FoodSearchData
    {
        public string FoodName { get; set; }

        public int Price { get; set; }

        public bool IsVeg { get; set; }

        public string SearchQuery { get; set; }


        public override string ToString()
        {
            return $"FoodName: {FoodName}, Price: {Price}, IsVeg: {IsVeg}, SearchQuery: {SearchQuery}";
        }
    }
}
