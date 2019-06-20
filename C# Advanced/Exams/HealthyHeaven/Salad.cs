using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        public List<Vegetable> salad;
        public string Name { get; set; }
        public Salad()
        {
            Name = "none";
            salad = new List<Vegetable>();
        }
        public Salad(string name)
        {
            Name = name;
            salad = new List<Vegetable>();
        }
        public int GetTotalCalories()
        {
            int totalCalories = 0;
            foreach (var vegetable in salad)
            {
                totalCalories += vegetable.Calories;
            }
            return totalCalories;
        }
        public int GetProductCount()
        {
            return salad.Count ;
        }
        public void Add(Vegetable product)
        {
            salad.Add(product);
        }
        public override string ToString()
        {
            string outputString = $"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:" + Environment.NewLine;
            foreach (var product in salad)
            {
                outputString += " - " + product.ToString();
            }
            return outputString;

        }

    }
    
}
