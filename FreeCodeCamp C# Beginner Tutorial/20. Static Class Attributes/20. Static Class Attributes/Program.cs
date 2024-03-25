using System;

namespace _20._Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Anime Dbz = new Anime("Dragon Ball Z", 1988);
            Anime naruto = new Anime("Naruto Shippuden", 2007);

            Console.WriteLine(Dbz.name);        // calling name attribute by object of a class
            Console.WriteLine(Anime.counter);   //calling static attribute by class itself

            /*Here you can see that we are accessing the counter which is a static class attribute 
             by giving class itself an attribute*/
        }
    }
}
