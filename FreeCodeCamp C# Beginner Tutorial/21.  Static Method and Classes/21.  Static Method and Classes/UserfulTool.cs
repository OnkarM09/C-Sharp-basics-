using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.__Static_Method_and_Classes
{
    static class UserfulTool
    {
        //static method is a method which belongs to class itself
        /*below code shows an example of static method of class*/
        public static void sayHi(string name)
        {
            Console.WriteLine("Hello " + name + " Nice to meet you");
        }

        /*Note that this UsefulTool is class and it's instance can be created for example,
            UsefulTool tool = new UsefulTool();
        and if we try to create instance (object) of Math class then we get error because,
        it is a static class 
        To create static class use static word before class for example above class UsefulTool will be
        replaced by static class UsefulTool, So now we cannot create instance of this class*/
    }
}
