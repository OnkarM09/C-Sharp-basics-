using System;

namespace _4._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*+ for addition, - for substraction, * for multiplication, / for division, % for modulus*/

            /*Math Operator for different Math operations*/

            /*Absolute*/
            Console.WriteLine(Math.Abs(-8));

            /*Power of*/
            Console.WriteLine(Math.Pow(2, 8));     /*2^8*/

            /*Square Root*/
            Console.WriteLine(Math.Sqrt(144));

            /*Min and Max*/
            Console.WriteLine(Math.Max(2, 5));
            Console.WriteLine(Math.Min(5, 2));

            /*Round */
            Console.WriteLine(Math.Round(4.4));   /*op is 4*/
            Console.WriteLine(Math.Round(4.6));   /*op is 5*/



        }
    }
}
