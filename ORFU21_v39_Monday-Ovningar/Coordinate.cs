using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_v39_Monday_Ovningar
{
    class Coordinate
    {
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
        private int X { get; set; }
        private int Y { get; set; }

        public int MoveLeft()
        {
            Coordinate moveLeft = new();
            moveLeft.X = X - 1;
            return X = moveLeft.X;
        }

        public int MoveRight()
        {
            Coordinate moveRight = new();
            moveRight.X = X + 1;
            return X = moveRight.X;
        }

        public void GetPosition()
        {
            Console.WriteLine($"Current Position: X: {X, 2}, Y: {Y, 2}");
        }
    }
}
