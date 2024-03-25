using System;
using first_space;      //using namespace which we created below
using second_space;     

/*A namespace is designed for providing a way to keep one set of names separate from another.
 * The class names declared in one namespace does not conflict with the same class names declared in another.*/

namespace first_space
{
    class Print
    {
        public void func()
        {
            Console.WriteLine("This is inside first_space namespace");
        }
    }
}
namespace second_space
{
    class Print
    {
        public void func()
        {
            Console.WriteLine("This is inside secon_space");
        }
    }
}

namespace Namespaces              //Defining Namespace (Default)
{
    class Program
    {
        static void Main(string[] args)
        {
            //first_space.Print p = new first_space.Print();  //don't need to use that because we used using keyword for this namespace
            //p.func();
            /*Here it gets complicated because we have to write whole namespace for creating objec so we wil use 
            " using " keyword
            The using keyword states that the program is using the names in the given namespace. 
            For example, we are using the System namespace in our programs
            we only write,
            Console.WriteLine();
            It it wasn't using keyword we would have written as,
            System.Console.WriteLine();
            You can also avoid prepending of namespaces with the using namespace directive. This directive tells the compiler that 
            the subsequent code is making use of names in the specified namespace.
             */
            second_space.Print p = new second_space.Print();
            first_space.Print P1 = new first_space.Print();
            p.func();
            P1.func();
        }
    }
}
