using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
     class Person
    {
        public String Name { get; set; }
     public int Age { get; set; }
       public String City { get; set; }
    }

    class LINQ
    {
        static void Main(string[] args)
        {
            var People = new List<Person> {
            
            new Person{Name="Alice", Age =25,City="Kochi" },
            new Person {Name="Rinshad", Age =26,City="Kochi"},
            new Person {Name="Ravi", Age =30,City="Kochi" },
            new Person {Name="Riya", Age =22,City="Bangalore" },
            new Person {Name="Ahmed", Age =30,City="Calicut" },
            new Person {Name="Sulaiman", Age =20,City="Kochi" },
          
            };
            var above25 = People
                .Where(p => p.Age >=25 && p.City=="Kochi")
                .Select(p=> new {
                    p.Name,
                    p.Age,
                    p.City
                }).ToList();


            foreach(var person in above25)
            {
                           Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.City}");
            }
        }
    }
}
