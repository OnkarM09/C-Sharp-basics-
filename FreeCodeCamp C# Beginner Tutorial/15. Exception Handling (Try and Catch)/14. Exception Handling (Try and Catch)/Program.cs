using System;

namespace _14._Exception_Handling__Try_and_Catch_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2;
                Console.WriteLine("Enter the first value");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second value");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 + num2);
            }
            /*  catch
              {
                  Console.WriteLine("Error ocurred!");
              }*/
            //Or we can do 
            /*catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            //or we can specify certain exceptions 
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
/*
            and if we want, We can use finally { } for some cases as well*/
        }
    }
}
