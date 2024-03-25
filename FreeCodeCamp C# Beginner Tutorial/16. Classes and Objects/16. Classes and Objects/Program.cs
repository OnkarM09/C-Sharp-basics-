using System;

namespace _16._Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*To create a class in csharp go to the solution explorer and right click on project name in this case it is 16.Classess_and_Objects
            and then click on add new item
            after that click on class and always give capital letter to the begining of the class name*/


            //Now once we create class we are creating object of that class
            //An object is An instance of a class

            //creating our first class
            FirstClass person1 = new FirstClass();
            //This is an object of class(FirstClass)
            person1.firstName = "Onkar";
            person1.lastName = "Meherwade";
            person1.age = 23;

            Console.WriteLine(person1.firstName +"\n"+ person1.lastName + "\n" + person1.age);

            FirstClass person2 = new FirstClass();
            person2.firstName = "Goku";
            person2.lastName = "Son";
            person2.age = 99;
            Console.WriteLine(person2.lastName + " " + person2.firstName + " " + person2.age);

        }
    }
}
