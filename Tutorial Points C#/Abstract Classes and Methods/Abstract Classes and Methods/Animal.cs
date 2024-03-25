using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Methods
{
    /* Data abstraction is the process of hiding certain details and showing only essential information to the user.
     Abstraction can be achieved with either abstract classes or interfaces(which you will learn more about in the next chapter).

     The abstract keyword is used for classes and methods:
     Abstract class: is a restricted class that cannot be used to create objects(to access it, it must be inherited from another class).

     Abstract method: can only be used in an abstract class, and it does not have a body.The body is provided by the derived class (inherited from).
     An abstract class can have both abstract and regular methods:
     for example
         abstract class Animal    //creating abstract class
     {
         public abstract void showAnimal();    //defining abstract method
         public void print()
         {
             Console.WriteLine("This is normal method");
         }
     }
        If we try to create obj of abstract class then it gives you error, for example,
        Animal a=new Animal(); //will throw error
     */
    abstract class Animal
    {
        public abstract void showAnimal();   //abstract method does not have method body
        public void print()
        {
            Console.WriteLine("Chilling!"); 
        }
    }

}
