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

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var item in classNonPublicMethods.Where(p => p.Name.StartsWith("get")))
            {
                sb.AppendLine($"{item.Name} have to be public!");
            }
            foreach (var item in classPublicMethods.Where(p => p.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }


    }
}
