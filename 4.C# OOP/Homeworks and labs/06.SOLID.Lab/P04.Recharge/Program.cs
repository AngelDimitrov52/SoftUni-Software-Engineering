namespace P04.Recharge
{
    using System;

    class Program
    {
        static void Main()
        {

            Employee employee = new Employee("32");
            Robot robot = new Robot("34", 5);

            employee.Sleep();
            robot.Work(55);

        }
    }
}
