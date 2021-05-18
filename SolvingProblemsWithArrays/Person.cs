using System;

namespace SolvingProblemsWithArrays
{
    class Person
    {
        public string Name;
        public int Height;

        public Person()
        {
        }

        public Person(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public void Show()
        {
            Console.WriteLine("*********************");
            Console.WriteLine($"Navn:  {Name}");
            Console.WriteLine($"Høyde: {Height}");
            Console.WriteLine("*********************");
        }
    }
}
