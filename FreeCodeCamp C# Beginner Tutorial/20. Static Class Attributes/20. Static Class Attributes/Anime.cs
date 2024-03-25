using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._Static_Class_Attributes
{
    class Anime
    {
        public string name;
        public int year;
        public static int counter=0;
        /*Here static Attribute means that this doesn't belong to the perticular object that gets
          created by the instance of class, Instead this attributes belongs to the class itself*/

        public Anime(string aName, int aYear)
        {
            name = aName;
            year = aYear;
            counter++;
        }
    }
}
