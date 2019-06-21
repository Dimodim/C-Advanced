using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        public string Name { get;private set; }
        public int Level { get;private set; }
        public Item Item { get;private set; }
        public Hero(string name,int lvl,Item item)
        {
            Name = name;
            Level = lvl;
            Item = item;
        }
        public override string ToString()
        {
            string str = $"Hero: {Name} – {Level}lvl" + Environment.NewLine +
                         $"Item:" + Environment.NewLine + Item.ToString();
            return str;
        }
    }
}
