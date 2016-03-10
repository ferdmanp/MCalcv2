using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.attributes
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    sealed class ItemParameterAttribute:Attribute
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public object DefaultValue { get; set; }
    }
}
