using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.attributes
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    sealed class ItemPropertiesAttribute : Attribute
    {
        public string DefaultName { get; set; }       
    }
}
