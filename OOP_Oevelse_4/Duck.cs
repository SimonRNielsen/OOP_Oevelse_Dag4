﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_4
{
    public class Duck : Animal, IFlyable
    {
        private string animalType = "duck";
        private float flySpeed;
        public float FlySpeed { get => flySpeed; set => flySpeed = value; }

        public void Fly()
        {
            Console.WriteLine($"I'm a {this.animalType} and i'm flying");
        }
    }
}
