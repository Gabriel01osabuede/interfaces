using System;

namespace interfaces
{
    public abstract class Animals
    {
        public abstract void cats();
        public abstract void dogs();
    }


    public class Cats : Animals
    {
        public override void cats()
        {
            Console.WriteLine("Cats Meow");
        }
         public override void dogs()
        {
            Console.WriteLine("Dogs Bark");
        }


    }
    public class Dogs : Animals
    {
        public override void dogs()
        {
            Console.WriteLine("Dogs Bark");
        }

         public override void cats()
        {
            Console.WriteLine("Cats Meow");
        }

    }
}