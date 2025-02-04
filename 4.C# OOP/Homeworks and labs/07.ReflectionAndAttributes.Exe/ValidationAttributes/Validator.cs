﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object person)
        {
            PropertyInfo[] properties = person.GetType().GetProperties();

            foreach (var property in properties)
            {
                MyValidationAttribute[] attributes = property.GetCustomAttributes()
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                object value = property.GetValue(person);

                foreach (var attribute in attributes)
                {
                    bool isValid = attribute.IsValid(value);

                    if (!isValid)
                    {
                        return false; 
                    }

                }
            }
            return true;
        }
    }
}
