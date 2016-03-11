using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MCalcLib.objects;
using MCalcLib.attributes;

namespace MCalcLib.classes
{
    public class StandardValidator<T> where T:objectItemBase
    {
        public ValidationResult Validate(Standard standard)
        {
            var result = ValidationResult.Success;

            //var instance = Activator.CreateInstance<T>();

            foreach(PropertyInfo property in typeof(T).GetProperties(BindingFlags.Public))
            {
                foreach(var attr in property.GetCustomAttributes(typeof(BoundAttribute),false))
                {
                    string locStandardName = ((BoundAttribute)attr).StandardName;
                    if (standard.BoundProperties[locStandardName] == null)
                        result = ValidationResult.Failure;
                }
            }

            return result;
        }
    }
}
