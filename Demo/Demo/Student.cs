using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Student
    {
        private string name;

        public void setName(string _name)
        {
            name = _name;
            Console.WriteLine(name);     
                                                                // 6.example
        }
        public string getName()
        {
           
           return name;
        }


    }
}
