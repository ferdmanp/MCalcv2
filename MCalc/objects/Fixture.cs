using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MCalc.objects
{
    public class Fixture : ItemBase
    {
        const string DEFAULT_NAME = @"Арматура";


        private double diameter;

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }


        

        double getDensity()
        {
            return this.GetSquare() * 1000 * Constants.SteelDensity;
        }

        public override double GetSquare()
        {
            double retValue = 0;
            Debug.Assert(diameter > 0, @"Диаметр меньше 0!");

            if (diameter <= 0)
            {
                diameter = 0;
                retValue = 0;
            }
            else
            {
                retValue = (Math.PI / 4) * Math.Pow(diameter, 2);
            }
            return retValue;
        }


        #region --ItemBase--

        public override string Name
        {
            get
            {
                return DEFAULT_NAME;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override double DensityWeight
        {
            get
            {
                return getDensity();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        #endregion
    }
}
