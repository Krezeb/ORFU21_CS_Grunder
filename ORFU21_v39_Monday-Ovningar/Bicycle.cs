using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_v39_Monday_Ovningar
{
    class Bicycle
    {
        int _age;
        int _gear;

        public Bicycle(int age, int gear)
        {
            _age = age;
            _gear = gear;
        }

        public Bicycle(int age) : this (age, 1)
        {

        }

        public Bicycle() : this(0, 1)
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Age : {_age}");
            Console.WriteLine($"Gear: {_gear}");
        }
    }
}
