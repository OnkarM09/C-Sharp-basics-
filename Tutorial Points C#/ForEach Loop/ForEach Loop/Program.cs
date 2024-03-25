using System;

namespace ForEach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr=new int[10];
            int i, value=1;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
                value++;
                
            }
            /*for(i=0; i< arr.Length; i++)
            {
                Console.WriteLine("vale {0}\n",arr[i]);
            }*/
            /*Will use foreach loop instead of using this traditional way*/

            foreach(int val in arr)
            {
                Console.WriteLine(val);
            }
        }
    }
}
