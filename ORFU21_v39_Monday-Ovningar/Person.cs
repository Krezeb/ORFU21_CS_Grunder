using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_v39_Monday_Ovningar
{
    class Person
    {
        private int _age;
        private string _name;

        public Person() : this("John Doe", 35)
        {
        }

        public Person(string name, int age)
        {
            _age = age;
            _name = name;
        }

        public int Age
        {
            get { return _age; }
            set 
            {
                if(value < 1) 
                {
                    _age = 1; 
                }
                else if(value > 100)
                { 
                    _age = 100; 
                }
                else
                { 
                    _age = value; 
                }
            }
        }

        //public void SetAge()
        //{
        //    SetAge(0);
        //}
        //public void SetAge(int age)
        //{
        //    if (age < 1) { age = 1; };
        //    if (age > 100) { age = 100; };
        //    _age = age;
        //}
    }
}
