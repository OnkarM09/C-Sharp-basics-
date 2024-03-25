using System;

namespace Enum__Enumeration_
{
    class Program
    {
        enum Days {Sun, Mond, Tue, Wed, Thu, Fri, Sat };   //creating enum
        static void Main(string[] args)
        {

            /*An enumeration is a set of named integer constants. An enumerated type is declared using the enum keyword.
            C# enumerations are value data type. In other words, enumeration contains its own values and cannot inherit or 
            cannot pass inheritance.*/

            int weekDayStart = (int)Days.Mond;
            int weekDayEnd = (int)Days.Fri;

            Console.WriteLine("Weekday is : {0}", weekDayStart);
            Console.WriteLine("Weekday is : {0}", weekDayEnd);
        }
    }
}
