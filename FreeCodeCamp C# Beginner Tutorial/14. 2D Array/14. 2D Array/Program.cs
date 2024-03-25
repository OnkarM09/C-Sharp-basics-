using System;

namespace _14._2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = { {1,2,3}, 
                                  {4,5,6 },
                                  {7,8,9 } 
            };

            for (int i = 0; i <numberGrid.GetLength(0); i++){
                   for(int j=0; j< numberGrid.GetLength(1); j++)
                {
                    Console.WriteLine(numberGrid[i,j]);
                }
            }
        }
    }
}
