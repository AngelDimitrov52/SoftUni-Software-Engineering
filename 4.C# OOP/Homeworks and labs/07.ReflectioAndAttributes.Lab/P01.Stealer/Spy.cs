using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
      
        public string StealFieldInfo(string className, params string[] classFieldsNames)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {className}");

            foreach (var field in classFields.Where(p => classFieldsNames.Contains(p.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }


    }
}
