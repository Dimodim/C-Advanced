using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Weapon
    {
        public int Size { get; private set; }
        public int Solidity { get; private set; }
        public int Sharpness { get; private set; }
        public Weapon(int size,int solidity,int sharpness)
        {
            Size = size;
            Solidity = solidity;
            Sharpness = sharpness;
        }  
    }
}
