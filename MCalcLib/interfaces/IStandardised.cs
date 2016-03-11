using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.classes;

namespace MCalcLib.interfaces
{
    public interface IStandardised
    {
        /// <summary>
        /// Заполнить параметры из ГОСТа
        /// </summary>
        void ApplyStandard(Standard standard);
        
    }
}
