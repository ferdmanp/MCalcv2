using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;

namespace MCalcLib.objects
{
    public abstract class objectItemBase
    {
        
        /// <summary>
        /// Название элемента
        /// </summary>
        [ItemParameter(DisplayName = @"Название")]
        public abstract string Name { get; set; }

        
    }
}
