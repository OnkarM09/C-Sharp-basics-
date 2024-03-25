using System;

namespace _6._Simple_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Convertig String Into a Number */
            int num = Convert.ToInt32("45");
            Console.WriteLine(num - 5);


            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1.Addition 2.Substraction 3.Multiplication 4.Division \nEnter your choice: ");
            int Case= Convert.ToInt32(Console.ReadLine());

            switch (Case)
            {
                case 1:
                    Console.WriteLine("The Addition is " + (num1 + num2));
                    break;
                case 2: Console.WriteLine("The Substraction is " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("The Multiplication is " + (num1 * num2));
                    break;
                case 4: Console.WriteLine("The Division is " + (num1 / num2));
                    break;
                default: Console.WriteLine("You have entered wrong choice!");
                    break;
            }


        }
    }
}
