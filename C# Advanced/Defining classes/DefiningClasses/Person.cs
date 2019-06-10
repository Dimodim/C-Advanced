using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
        // constructors
        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }
        public Person(int age,string name)
        {
            this.name = name;
            this.age = age;
        }
        
    }
}
