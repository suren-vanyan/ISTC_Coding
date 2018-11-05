﻿using System;
using System.Collections.Generic;
using System.Text;
using Animals.Animals;

namespace Animals.Herbivore
{
    class Herbivore:Animal
    {
        public bool CanWalk { get; set; }
        public int Legs { get; set; }
        public string Fur { get; set; }

        public Herbivore(bool canWalk, int legs, string fur, string name, int speed,int age)
                                                                         : base(name, speed,age)
        {
            CanWalk = canWalk;
            Legs = legs;
            Fur = fur;
        }

        public string Eat()
        {
            return "Carrot";
        }
    }
}
