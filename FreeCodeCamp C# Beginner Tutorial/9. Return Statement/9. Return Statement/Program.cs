using System;

namespace _9._Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(3));
        }
        
        static int Cube(int num)
        {
            int result =Convert.ToInt32( Math.Pow(num, 3));
            return result;
        }

         /*We can return String, Array, Double instead of int*/
    }
}
