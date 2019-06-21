using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        public Dictionary<string, Hero> heroes;
        public HeroRepository()
        {
            heroes = new Dictionary<string, Hero>();
        }
        public void Add(Hero hero)
        {
            heroes.Add(hero.Name, hero);
        }
        public void Remove(string name)
        {
            if (heroes.ContainsKey(name))
            {
                heroes.Remove(name);
            }
        }
        public Hero GetHeroWithHighestStrength()
        {
            if (heroes.Count > 0)
            {
                Hero heroWithHighestStrength = new Hero("", 0, new Item(0, 0, 0));
                foreach (var hero in heroes)
                {
                    if (heroWithHighestStrength.Item.Strength < hero.Value.Item.Strength)
                    {
                        heroWithHighestStrength = hero.Value;
                    }
                }
                return heroWithHighestStrength;

            }
            return null;
        }
        public Hero GetHeroWithHighestAbility()
        {
            if (heroes.Count > 0)
            {
                Hero heroWithHighestAbility = new Hero("", 0, new Item(0, 0, 0));
                foreach (var hero in heroes)
                {
                    if (heroWithHighestAbility.Item.Ability < hero.Value.Item.Ability)
                    {
                        heroWithHighestAbility = hero.Value;
                    }
                }
                return heroWithHighestAbility;

            }
            return null;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            if (heroes.Count > 0)
            {
                Hero HeroWithHighestIntelligence = new Hero("", 0, new Item(0, 0, 0));
                foreach (var hero in heroes)
                {
                    if (HeroWithHighestIntelligence.Item.Intelligence < hero.Value.Item.Intelligence)
                    {
                        HeroWithHighestIntelligence = hero.Value;
                    }
                }
                return HeroWithHighestIntelligence;

            }
            return null;
        }
        public int Count
        {
            get { return heroes.Count; }
        }
        public override string ToString()
        {
            string allHeroes = "";
            foreach (var hero in heroes)
            {
                allHeroes+= hero.Value.ToString()+Environment.NewLine;
            }
            return allHeroes;
        }
    }
}
