using System.ComponentModel.DataAnnotations;


namespace _01_using_model.Controllers
{
    public class Food
    {
        [Range(0, 999), EvenValidation]
        public int Id { get; set; }

        [MinLength(2), MaxLength(10)]
        public string Name { get; set; }

        [Range(10, 200)]
        public decimal Price { get; set; }

        [MinLength(10), MaxLength(70)]
        public string Description { get; set; }

        public bool IsVeg { get; set; }

        public Taste FoodTaste { get; set; }

    }
}