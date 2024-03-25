using System;

namespace _21.__Static_Method_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //static methods can be extremely useful, let's  take an example of Math.Sqrt()
            Console.WriteLine(Math.Sqrt(144));
            /*So basically Math is a class and Sqrt is and static method of that
            so by creating this static method we don't need to create instance of Math class for example,
            Math m1=new Math()
            so that's how useful static classes are!*/

            UserfulTool.sayHi("Onkar");  //calling our static method

            //UserfulTool tool = new UserfulTool(); //gives you error because this is a static class
        }
    }
}
