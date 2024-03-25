using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_and_Abstract_Class
{    /*The word polymorphism means having many forms.In object-oriented programming paradigm, polymorphism is often expressed as 'one interface, multiple functions'.

           Polymorphism can be static or dynamic. In static polymorphism, the response to a function is determined at the compile time.In dynamic polymorphism, it is decided at run - time.

           Static Polymorphism
           The mechanism of linking a function with an object during compile time is called early binding.It is also called static binding.
           C# provides two techniques to implement static polymorphism. 
           They are 
           Function overloading
           Operator overloading

           Function Overloading
           You can have multiple definitions for the same function name in the same scope.The definition of the function must differ from each other by the types 
           and / or the number of arguments in the argument list.You cannot overload function declarations that differ only by return type.

           The following example shows using function print() to print different data types*/
    class Printdata
    {
        public void print(int i)
        {
            Console.WriteLine("Printint int {0}", i);
        }
        public void print(double f)
        {
            Console.WriteLine("Printint double {0}", f);
        }
        public void print(string s)
        {
            Console.WriteLine("Printint string {0}", s);
        }
    }
}
