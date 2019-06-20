using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthyHeaven
{
    public class Restaurant
    {
        public Dictionary<string, Salad> data;
        public string Name { get; set; }
        public Restaurant(string name)
        {
            Name = name;
            data = new Dictionary<string, Salad>();
        }
        public void Add(Salad salad)
        {
            data.Add(salad.Name, salad);
        }
        public bool Buy(string name)
        {
            bool buy = false;
            if (data.ContainsKey(name))
            {
                data.Remove(name);
                buy = true;
            }
            return buy;
        }
        public Salad GetHealthiestSalad()
        {
            Salad helthyestSalad = new Salad();
            foreach (var salad in data)
            {
                
                if (helthyestSalad.Name=="none")
                {
                    helthyestSalad = salad.Value;
                }
                else if (helthyestSalad.GetTotalCalories() > salad.Value.GetTotalCalories())
                {
                    helthyestSalad = salad.Value;
                }
                
            }
            return helthyestSalad;
        }
        public string GenerateMenu()
        {
            string str = $"{Name} have {data.Count} salads:" + Environment.NewLine;
            
            foreach (var salad in data)
            {
                str+=salad.ToString()+Environment.NewLine;
            }

            return str;
        }

    }
}
