using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_and_Abstract_Class
{
    /*
     Dynamic Polymorphism
    C# allows you to create abstract classes that are used to provide partial class implementation of an interface. 
    Implementation is completed when a derived class inherits from it. Abstract classes contain abstract methods,
    which are implemented by the derived class. The derived classes have more specialized functionality.

    Here are the rules about abstract classes −

    You cannot create an instance of an abstract class
    You cannot declare an abstract method outside an abstract class
    When a class is declared sealed, it cannot be inherited, abstract classes cannot be declared sealed.
     */
    abstract class Shape
    {
        public abstract int area();
    }
    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
   
}
