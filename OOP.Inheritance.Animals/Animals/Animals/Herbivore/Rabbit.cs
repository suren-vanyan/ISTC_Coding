﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Herbivore
{
    class Rabbit:Herbivore
    {
        public Rabbit(bool canWalk, int legs, string fur, string name, int speed,int age)
                         : base(canWalk, legs, fur, name, speed,age)
        {
            CanWalk = canWalk;
            Legs = legs;
            Fur = fur;
        }
    }
}
