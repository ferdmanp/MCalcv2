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
                foreach(var attr in property.GetCustomAttributes(typeof(BoundAttribute),false))
                {
                    result = ValidationResult.Failure;
                    string locStandardName = ((BoundAttribute)attr).StandardName;                    
                    if(!standard.Bounds.ContainsKey(locStandardName))
                        result = ValidationResult.Failure;
                    else
                        result = ValidationResult.Success;
                }
            }

            return result;
        }
    }
}
