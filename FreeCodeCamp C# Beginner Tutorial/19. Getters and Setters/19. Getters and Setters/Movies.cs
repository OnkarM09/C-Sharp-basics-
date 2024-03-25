using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._Getters_and_Setters
{
    class Movies
    {
        public string name;
        public int year;
        // public int ratings;
        private int ratings;       //setting ratings from public to private
        //to use getters and setters we have to make this from public to private 

        public Movies(string aName, int aYear, int aRatings)
        {
            name = aName;
            year = aYear;
            //ratings = aRatings;
            // to secure more we can call this getter setter property which is defined below
            Rating = aRatings;
        }
        public int Rating
        {
            get { return ratings; }
            set
            {
                if (ratings <= 10)
                {
                    value = ratings;
                }
                else
                {
                    value = 0;
                }
            }
        }
    }
}
