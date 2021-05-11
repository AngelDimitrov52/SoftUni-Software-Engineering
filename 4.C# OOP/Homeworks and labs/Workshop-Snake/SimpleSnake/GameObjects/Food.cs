using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private char foodSymbol;
        private Wall wall;
        private Random random;
        protected Food(Wall wall, int points, char foodSymbol)
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            FoodPoints = points;
            this.foodSymbol = foodSymbol;
            random = new Random();
        }
        public int FoodPoints { get; private set; }

        public void SetRandomPosition(Queue<Point> snakeElement)
        {
            LeftX = random.Next(2, wall.LeftX - 2);
            TopY = random.Next(2, wall.TopY - 2);

            bool isPointOfSnake = snakeElement.Any(x => x.LeftX == LeftX && x.TopY == TopY);

            if (isPointOfSnake)
            {
                LeftX = random.Next(2, wall.LeftX - 2);
                TopY = random.Next(2, wall.TopY - 2);

                isPointOfSnake = snakeElement.Any(x => x.LeftX == LeftX && x.TopY == TopY);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;

        }

        public bool IsFoodPiont(Point snake)
        {
            return snake.TopY == TopY && snake.LeftX == LeftX;
        }
    }
}
