﻿using System;

namespace DuckStuff
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with my wings!");
        }
    }
}
