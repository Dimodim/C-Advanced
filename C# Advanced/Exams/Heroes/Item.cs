using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        public int Strength { get;private set; }
        public int Ability { get; private set; }
        public int Intelligence { get; private set; }
        public Item(int strenght,int ability,int intelligence)
        {
            Strength = strenght;
            Ability = ability;
            Intelligence = intelligence;

        }
        public override string ToString()
        {
            string output = $"  * Strength: {Strength}"+Environment.NewLine+
            $"  * Ability: {Ability}" + Environment.NewLine +
            $"  * Intelligence: {Intelligence}";

            return output;
        }
    }
}
