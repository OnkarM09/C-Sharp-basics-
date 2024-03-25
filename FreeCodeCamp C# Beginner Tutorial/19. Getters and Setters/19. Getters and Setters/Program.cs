using System;

namespace _19._Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies m1 = new Movies("The Avengers", 2012, 8);
            Movies m2 = new Movies("Justice League", 2012, 40);
            //m2.ratings = 29;

            Console.WriteLine(m1.Rating); // Calling getter and setter property
        }
    }
}
