using System;

namespace _12._While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            while(num >=1)
            {
                num--;
                Console.WriteLine(num);
            }


            do
            {
                num++;
                Console.WriteLine(num);
            } while (num <= 10);
        }
    }
}
