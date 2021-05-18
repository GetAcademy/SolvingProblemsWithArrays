using System;

namespace SolvingProblemsWithArrays
{
    class OODemo
    {
        public static void Run()
        {
            /*
                var person = {
                    name: 'Terje',
                    height: 180,
                }

            person = {}
            person.name = 'Terje'
            person.height = 180
            */
            var person = new Person();
            person.Name = "Terje";
            person.Height = 180;

            var person2 = new Person
            {
                Name = "Terje",
                Height = 180
            };


            /*
             model = {
                people: [
                    { name: 'Terje', height: 180,},
                    { name: 'Per', height: 181,},
                ],
            }
             */
            var model = new Model();
            model.people = new Person[2];
            model.people[0] = new Person { Name = "Terje", Height = 180 };
            model.people[1] = new Person { Name = "Per", Height = 181 };

            var model2 = new Model
            {
                people = new Person[]
                {
                    new Person { Name = "Terje", Height = 180 },
                    new Person { Name = "Per", Height = 181 },
                }
            };


            /*
             * Mer objektorientert
             */
            var person3 = new Person
            {
                Name = "Terje",
                Height = 180
            };
            Show(person3);
            person3.Show();

            var person4 = new Person
            {
                Name = "Per",
                Height = 181
            };
            person4.Show();

     
        }

        public static void Show(Person person)
        {
            Console.WriteLine("*********************");
            Console.WriteLine($"Navn:  {person.Name}");
            Console.WriteLine($"Høyde: {person.Height}");
            Console.WriteLine("*********************");
        }

        public static void Run2()
        {
            var person5 = new Person("Terje", 180);
        }
    }
}
