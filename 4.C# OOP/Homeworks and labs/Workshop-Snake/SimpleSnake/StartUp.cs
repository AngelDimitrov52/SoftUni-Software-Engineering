namespace SimpleSnake
{
    using SimpleSnake.GameObjects;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();
            
            Wall wall = new Wall(50, 20);
            Food food = new FoodDollar(wall , 4 , '@');
            food.SetRandomPosition(new System.Collections.Generic.Queue<Point>());
        }
    }
}
