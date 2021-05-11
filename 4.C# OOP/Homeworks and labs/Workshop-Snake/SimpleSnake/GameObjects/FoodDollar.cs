using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodDollar : Food
    {
        private const char foodSymbol = '&';
        private const int points = 2;
        public FoodDollar(Wall wall, int points, char foodSymbol)
            : base(wall, points, foodSymbol)
        {
        }
    }
}