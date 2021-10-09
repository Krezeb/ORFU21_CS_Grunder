using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_v39_Monday_Ovningar
{
    class InitPair
    {
        private int _num1;
        private int _num2;
        private int _sumAverage;

        public InitPair():this (0,0)
        {
        }

        public InitPair(int param1, int param2)
        {
            _num1 = param1;
            _num2 = param2;
            SumAverage(param1, param2);
        }

        public void SetNum(int param1, int param2)
        {
            _num1 = param1;
            _num2 = param2;
            SumAverage(param1, param2);
        }
        public void SetNumOne(int param1)
        {
            _num1 = param1;
            SumAverage(param1, _num2);
        }

        public void SetNumTwo(int param2)
        {
            _num2 = param2;
            SumAverage(_num1, param2);
        }


        private void SumAverage(int param1, int param2)
        {
            _sumAverage = (param1 + param2) / 2;
        }

        public int GetAverage() //Getter that returns average
        {
            return _sumAverage;
        }
        public void GetAllNums() //Getter that shows both numbers
        {
            Console.WriteLine($"Number 1 is: {_num1}");
            Console.WriteLine($"Number 2 is: {_num2}");
        }
        public int GetNumOne() //Getter that returns _num1
        {
            return _num1;
        }
        public int GetNumTwo() //Getter that returns _num2
        {
            return _num2;
        }

        public int PropNumOne { get; set; }
        public int PropNumTwo { get; set; }
        public int PropArea
        {
            get { return PropNumOne * PropNumTwo; }
        }
    }
}
