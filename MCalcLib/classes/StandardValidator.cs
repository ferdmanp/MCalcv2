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
            var result = ValidationResult.Undefined;

            //var instance = Activator.CreateInstance<T>();
            var propertyInfoArray = typeof(T).GetProperties();
            foreach(PropertyInfo property in propertyInfoArray)
            {
                result = ValidationResult.Failure;
                foreach(var attr in property.GetCustomAttributes(typeof(BoundAttribute),false))
                {
                    string locStandardName = ((BoundAttribute)attr).StandardName;
                    if (standard.Bounds[locStandardName] == null)
                        result = ValidationResult.Failure;
                    else
                        result = ValidationResult.Success;
                }
            }

            return result;
        }
    }
}
