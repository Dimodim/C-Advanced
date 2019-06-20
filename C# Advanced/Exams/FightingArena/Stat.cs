using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Stat
    {
        public int Strength { get; private set; }
        public int Flexibility { get; private set; }
        public int Agility { get; private set; }
        public int Skills { get; private set; }
        public int Intelligence { get; private set; }
        public Stat(int strength, int flexibility, int agility, int skills, int intelligence)
        {
            Strength = strength;
            Flexibility = flexibility;
            Agility = agility;
            Skills = skills;
            Intelligence = intelligence;
        }

    }
}
