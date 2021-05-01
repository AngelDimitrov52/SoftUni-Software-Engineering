using System;

namespace P01.Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instace;
            var db2 = SingletonDataContainer.Instace;
            var db3 = SingletonDataContainer.Instace;
            var db4 = SingletonDataContainer.Instace;
        }
    }
}
