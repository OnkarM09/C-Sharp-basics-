using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._Object_Methods
{
    class Student
    {
        //defining object attributes
        public string name;
        public string college;
        public int gpa;

        //creating constructor
        public Student(string cname, string ccollege, int cgpa)
        {
            name = cname;
            college = ccollege;
            gpa = cgpa;
        }
        //creating method
        public bool HasHonurs()
        {
            if(gpa >= 4)
            {
                return true;
            }
            return false;
        }
    }

    
    
}
