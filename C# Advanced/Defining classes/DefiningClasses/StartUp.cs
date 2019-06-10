using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[]args)
        {
            Family family = new Family();
            int countOfMembers = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfMembers; i++)
            {
                string[] member = Console.ReadLine().Split();
                string name = member[0];
                int age = int.Parse(member[1]);
                Person person = new Person(age,name);
                
                family.AddMember(person);
            }
            List<Person> inOrAboveThirtys = family.GetMembersAboveThirty();
            foreach (var person in inOrAboveThirtys)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }


        }
    }
}
