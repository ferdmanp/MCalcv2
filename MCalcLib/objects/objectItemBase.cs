using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;

namespace MCalcLib.objects
{
    public abstract class objectItemBase
    {
        const int TEMP_DENSITY = 1;
        /// <summary>
        /// Название элемента
        /// </summary>
        [ItemParameter(DisplayName = @"Название")]
        public abstract string Name { get; set; }

        /// <summary>
        /// Удельный вес погонного метра, кг
        /// </summary>
        [ItemParameter(DisplayName = @"Погонный вес")]
        public double DensityWeight {
            get { return GetSquare() * 1000 * TEMP_DENSITY; }            
        }

        /// <summary>
        /// Получает площадь сечения
        /// </summary>
        /// <returns></returns>
        public abstract double GetSquare();
    }
}
