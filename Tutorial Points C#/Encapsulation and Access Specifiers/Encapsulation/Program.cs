using System;

namespace Encapsulation
{
    class newClass
    {
        public int num = 1;  //public access specifier
        
        public int factorial(int num)
        {
            int result = 0;
            if (num == 1)
            {
                return result = 1;
            }
            else
            {
                result = factorial(num - 1) + num;
            }
            return result;
        }
    }
    class newClass1
    {
        private int num = 10;  //private access specifier
    }
    class newClass2
    {
        internal int num = 20;  //internal access specifier
    }
    class Program
    {
        static void Main(string[] args)
        {
            newClass n = new newClass();
            
            Console.WriteLine(n.factorial(4));

            /*Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'. 
            Encapsulation, in object oriented programming methodology, prevents access to implementation details.
            
             Encapsulation is implemented by using access specifiers. An access specifier defines the scope and visibility of a 
             class member. C# supports the following access specifiers
               
             public, private, protected, internal, protected internal
            
             by using public access specifier we can use member variables and methods anywhere

            Private Access Specifier
            Private access specifier allows a class to hide its member variables and member functions from 
            other functions and objects. Only functions of the same class can access its private members. 
            Even an instance of a class cannot access its private members.

            Protected Access Specifier
            Protected access specifier allows a child class to access the member variables and member functions of its base class. 
            This way it helps in implementing inheritance

            Internal Access Specifier
            Internal access specifier allows a class to expose its member variables and member functions to other functions and objects 
            in the current assembly. In other words, any member with internal access specifier can be accessed from any class or method 
            defined within the application in which the member is defined.

            Protected Internal Access Specifier
            The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, 
            except a child class within the same application. This is also used while implementing inheritance.
             */
        }
    }
}
