using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;

namespace MCalcLib.objects
{
    abstract class objectSimpleItemBase : objectItemBase
    {
        const int TEMP_DENSITY = 1;

        protected objectSimpleItemBase()
        {

        }

        protected objectSimpleItemBase(string Name)
        {
            this.Name = Name;
        }



        /// <summary>
        /// Удельный вес погонного метра, кг
        /// </summary>
        [ItemParameter(DisplayName = @"Погонный вес")]
        public virtual double DensityWeight
        {
            get { return GetSquare() * 1000 * TEMP_DENSITY; }
            set { DensityWeight = value; }
        }

        /// <summary>
        /// Получает площадь сечения
        /// </summary>
        /// <returns></returns>
        public abstract double GetSquare();
    }
}
