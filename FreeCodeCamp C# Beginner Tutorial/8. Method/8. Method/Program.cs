using System;

namespace _8._Method
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayHelloToName("Son Goku");
        }
        

        /*void cannot return anything */
        static void SayHello()
        {
            Console.WriteLine("Hello User");
        }
        static void SayHelloToName(string name)            /*These are called parameters or arguments*/
        {
            Console.WriteLine("Hello There "+ name);
        }
    }
}
