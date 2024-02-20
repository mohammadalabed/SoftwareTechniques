using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace language_tools
{
    internal class Student
    {
        private string name;
        //private int age;

         public string GetName()
        {
            return name;
        }
        public void SetName(string name2)
        {
            this.name = name2;
        }
        private int age;
        public int Age 
        { 
            get { return age; }
            //set { age = value; }
            set { 
                if(value < 0) age = 0;
                else
                age = value; 
                }
        }

        // I can write the previouse line with one line
        public int Age2 { get; set; }

        // useing expression-bodied 
        public int YearOfBirht => 2024 - age; // no get or set or value keywords
    }
}
