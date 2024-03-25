using System;

namespace _7._Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Initializing Array */
            int[] myArray = { 2, 3, 4, 5, 6};
            for (int i = 0; i < myArray.Length; i++)
            {
            Console.WriteLine(myArray[i]);
            }

            string[] friends = new string[3];
            friends[0] = "Naruto";
            friends[1] = "Sasuke";
            friends[2] = "Sakura";
            Console.Write(friends[0]);

            //Taking array as an input from the user
            int[] myArr = new int[5];
            int i;
            Console.WriteLine("Enter the 5 values in an array");
            for (i = 0; i < 5; i++)
            {
                myArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values in an array is ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} value = {1}", i, myArr[i]);
            }
        }
    }
}
