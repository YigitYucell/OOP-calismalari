using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class student
    {
        public class Person
        {
            public string FirstName;
            public string LastName;

            public void DisplayFullName()
            {
                Console.WriteLine("Full Name: {0} ,{1}" , FirstName , LastName);
            }
        }

        public class Student : Person
        {
            public int StudentID;

            public void Study()
            {
                Console.WriteLine("Studying...");
            }
        }

    }
}
