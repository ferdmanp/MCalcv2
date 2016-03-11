using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;

namespace MCalcLib.objects
{
    [ItemProperties(DefaultName = @"Арматура")]
    public class objectFixture : objectItemBase
    {
        /// <summary>
        /// Диаметр детали
        /// </summary>
        [Bound(StandardName="d",Description="Диаметр,мм")]
        public double Diameter { get; set; }


        #region --Overrided--
        public new double DensityWeight
        {
            get
            {
                return base.DensityWeight;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override double GetSquare()
        {
            double retSquare = 0;

            if (Diameter > 0)
                //calculate square using formula s=(pi/4)*diameter^2
                retSquare = Math.PI / 4 * Math.Pow(Diameter, 2);
            else
            {
                throw new ArgumentException(@"Диаметр не может быть меньше или равен 0!");
                //TODO: log error
            }           

            return retSquare;
        }

        #endregion
    }
}
