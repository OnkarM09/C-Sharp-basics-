using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._Inheritance
{
    //So in Inheritance we can inherit all the properties from Super Class (Parent Class) which is to be inherited to the Sub class (child class)
    class IndianChef : Chef     //Here we are inherted all the methods from Chef  Here IndianChef is Sub class and Chef is Super Class
    {
        //we can create method apart from super class
        public void subji()
        {
            Console.WriteLine("I can make subji");
        }

        //Method Overriding
        /*Now let's say if we want to change the method from super class for example here,
          chef class has special dish as thali and we want to change special dish for IndianChef
          so what we can do to achieve that is to use Method Overriding.
          So what is method overriding, is that we can overwrite whatever functionality is written in 
          Super class for example here,
          We have thali in super class now wil change that to biryani and to achieve that we will use Virtual Keyword
          for that method in Super class and Overriding keyword for method in sub class*/

        public override void SpecialDish()    //using overrding keyword to overwrite method from super class
        {
            Console.WriteLine("I can make Biryani");
        }
    }
}
