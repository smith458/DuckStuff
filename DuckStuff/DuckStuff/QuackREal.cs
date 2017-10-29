using System;

namespace DuckStuff
{
    public class QuackReal : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
