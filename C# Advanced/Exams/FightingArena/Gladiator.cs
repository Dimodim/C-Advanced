using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public string Name{ get; private set; }
        public Stat Stat { get; private set; }
        public Weapon Weapon { get; private set; }
        public Gladiator(string name,Stat stat,Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }
        public int GetTotalPower()
        {
            int power = Stat.Agility
                + Stat.Flexibility
                + Stat.Intelligence
                + Stat.Strength
                + Stat.Skills
                + Weapon.Sharpness
                + Weapon.Size
                + Weapon.Solidity;
            return power;
        }
        public int GetWeaponPower()
        {
            int weponPower = Weapon.Sharpness
                + Weapon.Size
                + Weapon.Solidity;
            return weponPower;
        }
        public int GetStatPower()
        {
            int statsPower = Stat.Agility
                + Stat.Flexibility
                + Stat.Intelligence
                + Stat.Strength
                + Stat.Skills;
            return statsPower;
        }
        public override string ToString()
        {
            string result = $"{Name} - {GetTotalPower()}" +
                Environment.NewLine +
                $"  Weapon Power: {GetWeaponPower()}" +
                Environment.NewLine +
                $"  Stat Power: {GetStatPower()}";
            return result;
        }
    }
}
