using System;

namespace _5._Getting_Inpur_From_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hii " + name+ " You are "+ age + " years old!");
        }
    }
}
