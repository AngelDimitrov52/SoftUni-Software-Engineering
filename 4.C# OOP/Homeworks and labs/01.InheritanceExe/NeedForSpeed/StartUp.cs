namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar car = new SportCar(10, 100);
           car.Drive(10);
            System.Console.WriteLine(car.Fuel);
        }
    }
}
