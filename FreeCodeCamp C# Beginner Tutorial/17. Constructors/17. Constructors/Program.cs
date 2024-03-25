using System;

namespace _17._Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //so we can pass the object values by creating constructor
            Person p1 = new Person("Naruto","Uzumaki",23);
            /*p1.fName = "Naruto";
            p1.lName = "Uzumaki";
            p1.age = 23;*/


            Console.WriteLine(p1.fName +" "+ p1.lName + " "+ p1.age);
        }
    }
}
