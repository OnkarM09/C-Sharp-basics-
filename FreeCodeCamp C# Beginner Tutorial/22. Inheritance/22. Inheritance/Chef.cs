using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._Inheritance
{
    class Chef
    {
        public void  salad()
        {
            Console.WriteLine("I can make salad");
        }
        public void  roti()
        {
            Console.WriteLine("I can make roti");
        }
        public void  rice()
        {
            Console.WriteLine("I can make rice");
        }
        public virtual void SpecialDish()
        {
            Console.WriteLine("I can make Thali!");
        }
    }
}
