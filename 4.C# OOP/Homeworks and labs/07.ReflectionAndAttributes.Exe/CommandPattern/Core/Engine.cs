using CommandPattern.Core.Contracts;
using System;


namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string comand = Console.ReadLine();

                string result = commandInterpreter.Read(comand);

                if (result == null)
                {
                    break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
