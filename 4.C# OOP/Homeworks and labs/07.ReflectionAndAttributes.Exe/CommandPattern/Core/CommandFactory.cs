using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{

    public class CommandFactory : ICommandFactory
    {
        private const string CommandSuffix = "Command";
        public ICommand CreateFactory(string comandType)
        {
            Type type = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{comandType}{CommandSuffix}");

            if (type == null)
            {
                throw new ArgumentException();
            }
            ICommand instantion = (ICommand)Activator.CreateInstance(type);

            return instantion;
        }
    }
}
