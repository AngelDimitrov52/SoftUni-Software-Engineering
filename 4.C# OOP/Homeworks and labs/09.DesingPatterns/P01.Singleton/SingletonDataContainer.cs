using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P01.Singleton
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        public SingletonDataContainer()
        {
            Console.WriteLine("Initializing sigleton object");

            var element = File.ReadAllLines("../../../captals.txt");
            for (int i = 0; i < element.Length; i += 2)
            {
                _capitals.Add(element[i], int.Parse(element[i + 1]));
            }
        }
        public int GetPolpulation(string name)
        {
            return _capitals[name];
        }

        public static SingletonDataContainer Instace => instnce;

        private static SingletonDataContainer instnce = new SingletonDataContainer();
    }
}
