﻿using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Doors
{
    public class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door");
        }
    }
}
