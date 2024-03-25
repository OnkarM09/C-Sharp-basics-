using System;

namespace _13._For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1; i<= 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] myArray = { 87, 576, 34, 34, 54, 34 };
            for(i=0;i<myArray.Length;i++)
            {
                Console.WriteLine(myArray[i]);
            }

           int res= GetPow(2, 8);
            Console.WriteLine(res);
        }
        static int GetPow(int num1, int num2) {
            int result=1;
            for(int i=0; i< num2; i++)
            {
               result =result * num1;
            }
            return result;

        }
    }
}
