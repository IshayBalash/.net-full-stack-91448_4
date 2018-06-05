using _02_namespace_v3;

namespace _02_namespace_v4
{
    class Person
    {

        //first way to add a ref to an outer namspace (inline)
        public _02_namespace_v2.Color EyeColor { get; set; }

        public Color HairColor { get; set; }

        //second way to add a ref to an outer namspace (using - in the top of the page)
        public Gender MyProperty { get; set; }


    }


    class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }
}
