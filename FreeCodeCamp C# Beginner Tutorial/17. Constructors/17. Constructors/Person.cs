using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._Constructors
{
    class Person
    {
        public string fName;
        public string lName;
        public int age;

       // Creating constructor
        public Person(string cfName, string clName, int cage)      //creating constructor
        {
            fName = cfName;                                         //defining values
            lName = clName;
            age = cage;
        }
    }
}
