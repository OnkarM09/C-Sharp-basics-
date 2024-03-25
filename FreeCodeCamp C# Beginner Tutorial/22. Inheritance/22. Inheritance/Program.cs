using System;

namespace _22._Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.roti();

            IndianChef indianChef = new IndianChef();
            indianChef.roti();
            indianChef.subji();

            chef.SpecialDish();
            indianChef.SpecialDish();


        }
    }
}
