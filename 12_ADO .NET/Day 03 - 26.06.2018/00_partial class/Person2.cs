namespace _01_partial_class
{
    partial class Person
    {
        public override string ToString()
        {
            return $"{Name} is {Age} years old, IsMale:{IsMale}";
        }
    }
}
