using System;

namespace Interface
{
    /*Another way to achieve abstraction in C#, is with interfaces.
    An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
    for example,
    interface Animal{
        void showAnimal();      //Interface method does not have method body
        void print();           //Interface method does not have method body
    }

    It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself 
    and others to remember that it is an interface and not a class.
    By default, members of an interface are abstract and public.

    Note: Interfaces can contain properties and methods, but not fields.
    for example,
    interface Animal{
        public string name; //This is field and you cannot declare this in interface
    }

    To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class. To implement 
    aninterface, use the : symbol (just like with inheritance). The body of the interface method is provided by the "implement"
    class. Note that you do not have to use the override keyword when implementing an interface

    Declaring Interfaces
    Interfaces are declared using the interface keyword. It is similar to class declaration. Interface statements are public by default
    
    An interface cannot contain a constructor
    
     Why And When To Use Interfaces?
    1) To achieve security - hide certain details and only show the important details of an object (interface).

    2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces. Note: To implement multiple interfaces, separate them with a comma (see example below).

    interface IFirst_Interface{
        void myFirstMethod();
    }
    interface ISecond_Interface{
    void mySecondMethod();
    }

    class CheckInterface: IFirst_Interface, ISecond_Interface{          //Multiple interfaces seperated by comma
    void myFirstMethod(){
        Console.WriteLine("This is first Method");
    }
    void mySecondMethod(){
        Console.WriteLine("This is Second Method");
    }
    CheckInterface c=new CheckInterface();
    c.myFirstMethod();
    c.mySecondMethdod();
     */

    interface IAnimal
    {
        void showAnimal();          //interface method does not have body
    }
    class Tiger : IAnimal
    {
        public void showAnimal()
        {
            Console.WriteLine("This is Tiger!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tiger t = new Tiger();
            t.showAnimal();
        }
    }
}
