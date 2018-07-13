using System.ComponentModel.DataAnnotations;


namespace _01_using_model.Controllers
{
    class EvenValidation : ValidationAttribute {
        public override bool IsValid(object value)
        {
            int num;
            int.TryParse(value.ToString(), out num);
            return num % 2 == 0;
        }
    }
}

