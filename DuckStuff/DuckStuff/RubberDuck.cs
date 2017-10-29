using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckStuff
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackSqueak();
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duckie.");
        }
    }
}
