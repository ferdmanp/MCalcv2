using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.attributes
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property,Inherited=false,AllowMultiple=true)]
    sealed class BoundAttribute : Attribute
    {
        /// <summary>
        /// Название параметра в ГОСТе
        /// </summary>
        public string StandardName { get; set; }

        /// <summary>
        /// Описание параметра
        /// </summary>
        public string Description { get; set; }
    }
}
