using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        public Dictionary<string, Gladiator> gladiators;
        public string Name { get;private set; }
        public Arena(string name)
        {
            Name = name;
            gladiators = new Dictionary<string, Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator.Name, gladiator);
        }
        public void Remove(string name)
        {
            if (gladiators.ContainsKey(name))
            {
                gladiators.Remove(name);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            if (gladiators.Count > 0)
            {
                Gladiator highestStatGladiator = new Gladiator("", new Stat(0, 0, 0, 0, 0), new Weapon(0, 0, 0));
                foreach (var gladiator in gladiators)
                {
                    if (highestStatGladiator.GetStatPower() < gladiator.Value.GetStatPower())
                    {
                        highestStatGladiator = gladiator.Value;
                    }
                }
                return highestStatGladiator;

            }
            return null;
        }
        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            if (gladiators.Count > 0)
            {
                Gladiator highestWeaponDmgGladiator = new Gladiator("", new Stat(0, 0, 0, 0, 0), new Weapon(0, 0, 0));
                foreach (var gladiator in gladiators)
                {
                    if (highestWeaponDmgGladiator.GetWeaponPower() < gladiator.Value.GetWeaponPower())
                    {
                        highestWeaponDmgGladiator = gladiator.Value;
                    }
                }
                return highestWeaponDmgGladiator;
            }
            return null;
        }
        public Gladiator GetGladitorWithHighestTotalPower()
        {
            if (gladiators.Count > 0)
            {
                Gladiator gladitorWithHighestTotalPower = new Gladiator("", new Stat(0, 0, 0, 0, 0), new Weapon(0, 0, 0));
                foreach (var gladiator in gladiators)
                {
                    if (gladitorWithHighestTotalPower.GetTotalPower() < gladiator.Value.GetTotalPower())
                    {
                        gladitorWithHighestTotalPower = gladiator.Value;
                    }
                }
                  return gladitorWithHighestTotalPower;
            }
                return null;
        }
        public int Count
        {
            get { return gladiators.Count; }
        }
        public override string ToString()
        {
            string arena = $"{Name} - {Count} gladiators are participating.";

            return arena;
        }

    }
}
