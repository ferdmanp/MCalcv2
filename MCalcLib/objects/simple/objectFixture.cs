using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.classes;
using MCalcLib.attributes;
using MCalcLib.exceptions;
using System.Diagnostics;

namespace MCalcLib.objects
{
    [ItemProperties(DefaultName=@"Арматура")]
    public class objectFixture:objectSimpleItemBase
    {
        private double _diameter;
        private void setParameters()
        {
            this.square = CalculateSquare();
            ///Формула S(m2)*L(m)*Density
            this.densityWeight = this.square / 1000000000.0*1000* TEMP_DENSITY;
        }
        /// <summary>
        /// Диаметр, мм
        /// </summary>
        /// 
        [Bound(StandardName = @"D", Description = @"Диаметр,мм")]
        public double Diameter
        {
            get
            {
                return _diameter;
            }
            set
            {
                _diameter = value;
                setParameters();

            }
        } 

        protected objectFixture() : base(@"Арматура") { }

        public objectFixture(double diameter):this()
        {            
            Diameter = diameter;
            setParameters();
        }
        



        #region --objectSimpleItemBase--

        private double CalculateSquare()
        {
            Debug.Assert(Diameter > 0, @"Diameter value is invalid!");
            if (Diameter <= 0) throw new InvalidBoundParameterException(@"Диаметр не может быть меньше или равен 0");

            return Math.PI / 4 * Math.Pow(Diameter, 2);
        }

        public override string Name { get; set; }

        
        
 
        #endregion

        public override string ToString()
        {
            return String.Format(
                @"Type: Fixture"+Environment.NewLine
                  +"Name: {0}"+Environment.NewLine
                  +"Diameter: {1}"+Environment.NewLine
                  +"Square: {2}"+Environment.NewLine
                  +"DensityWeight: {3}"+Environment.NewLine,
                  Name,Diameter,Square,DensityWeight                  
                );

        }
    }
}
