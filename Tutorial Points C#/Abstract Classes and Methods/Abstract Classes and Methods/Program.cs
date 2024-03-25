using System;

namespace Abstract_Classes_and_Methods
{
    class Lion: Animal
    {
        public override void showAnimal()
        {
            Console.WriteLine("This is Lion!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //To access abstract method we have to call it from child class
            Lion l = new Lion();
            l.showAnimal();
            l.print();
            /*Why And When To Use Abstract Classes and Methods?
            To achieve security -hide certain details and only show the important details of an object.
            Note: Abstraction can also be achieved with Interfaces*/
        }
    }
}
