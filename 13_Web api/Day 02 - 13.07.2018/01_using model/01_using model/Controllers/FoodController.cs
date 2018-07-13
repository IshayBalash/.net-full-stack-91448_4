using System.Collections.Generic;
using System.Web.Http;

namespace _01_using_model.Controllers
{
    public class FoodController : ApiController
    {
        // GET: api/Food
        public IEnumerable<Food> Get()
        {
            return new Food[] {
                new Food{ Id=2, Name="Water" ,
                            FoodTaste =Taste.Bitterness,
                            IsVeg =true,
                            Price =7,
                            Description = "drink 10 cups every day"}
            };
        }
    }
}
