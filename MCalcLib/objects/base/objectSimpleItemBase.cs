using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;

namespace MCalcLib.objects
{
    public abstract class objectSimpleItemBase : objectItemBase
    {
        /// <summary>
        /// Плотность стали 7800 кг/м3
        /// </summary>
        protected const int TEMP_DENSITY = 7800;

        protected double square;
        protected double densityWeight;

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
            get { return densityWeight; }
            protected set { densityWeight = value; }
        }

        /// <summary>
        /// Площадь сечения, мм^2
        /// </summary>
        public virtual double Square 
        {
            get { return square; }
            protected set { square = value; }
        }

        protected virtual void setParameters()
        {
            this.square = calculateSquare();
            this.densityWeight = this.square / 1000000000.0 * 1000 * TEMP_DENSITY;
        }

        protected abstract double calculateSquare();
        
    }
}
