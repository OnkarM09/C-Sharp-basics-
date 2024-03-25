using System;

namespace Structure
{


    /*In C#, a structure is a value type data type. It helps you to make a single variable hold related data of various data types. 
    The struct keyword is used for creating a structure.*/


    /*Creating a structure in cSharp*/
    struct Books
    {
        public string name;          
        public string author;
        public int pages;
    }
    //Creating stuctures and it's constructor
    struct Movie
    {
        public string name;
        public  void getMovieName(string aName)   //Creating constructor for structure
        {
            name = aName;
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Books book1;  //declaring book1 as book structure
            book1.name = "Onkar";
            book1.author = "onkar";
            book1.pages = 122;
            
            Console.WriteLine("Book has name of {0} and Book's author is {1} and Book's pages contains {2}",book1.name,book1.author,book1.pages);

            Movie m1 = new Movie();
            m1.getMovieName("The Avengeres Infinity War");


            /*Features of C# Structures
            You have already used a simple structure named Books. Structures in C# are quite different from that in traditional C or C++. 
            The C# structures have the following features −

            Structures can have methods, fields, indexers, properties, operator methods, and events.
            Structures can have defined constructors, but not destructors.However, you cannot define a default constructor for a structure. 
            The default constructor is automatically defined and cannot be changed.
            Unlike classes, structures cannot inherit other structures or classes.
            Structures cannot be used as a base for other structures or classes.
            A structure can implement one or more interfaces.
            Structure members cannot be specified as abstract, virtual, or protected.
            When you create a struct object using the New operator, it gets created and the appropriate constructor is called.Unlike classes, 
            structs can be instantiated without using the New operator.
            If the New operator is not used, the fields remain unassigned and the object cannot be used until all the fields are initialized.


            Class versus Structure
            Classes and Structures have the following basic differences −

            classes are reference types and structs are value types
            structures do not support inheritance
            structures cannot have default constructor*/
        }
    }
}
