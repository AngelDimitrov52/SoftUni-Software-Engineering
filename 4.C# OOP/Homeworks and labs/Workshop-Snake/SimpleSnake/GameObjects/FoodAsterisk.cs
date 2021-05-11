using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodAsterisk  : Food
    {
        private const char foodSymbol = '*';
        private const int points = 1;
        public FoodAsterisk(Wall wall, int points, char foodSymbol)
            : base(wall, points, foodSymbol)
        {
        }
    }
}
