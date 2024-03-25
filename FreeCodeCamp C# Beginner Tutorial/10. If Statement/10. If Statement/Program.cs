using System;

namespace _10._If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool male = true;
            if (male)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are not male!");
            }

            /* so here also we can use and operation (&&) or OR operation (||)*/


            /*else if*/

            bool legend = true;
            bool great = true;
            if(legend == false)
            {
                Console.WriteLine("You are not legend");
            }
            else if(legend == true)
            {
                Console.WriteLine("You are Legend");
            }else if (great==false)
            {
                Console.WriteLine("You are not great! ");
            }
            else
            {
                Console.WriteLine("You are great");
            }
        }
    }
}
