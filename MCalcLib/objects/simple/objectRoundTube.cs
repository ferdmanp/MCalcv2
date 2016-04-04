using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;

namespace MCalcLib.objects
{
    [ItemProperties(DefaultName = @"Труба круглая")]
    public class objectRoundTube:objectSimpleItemBase
    {

        private double _diameter;
        private double _wallThickness;
       

        [Bound(StandardName="D", Description="Наружный диаметр, мм")]
        public double Diameter
        {
            get { return _diameter; }
            set { _diameter = value; setParameters(); }
        }

        [Bound(StandardName = "h", Description = "Толщина стенки, мм")]
        public double WallThickness
        {
            get { return _wallThickness; }
            set { _wallThickness = value; setParameters(); }
        }


        public objectRoundTube(double diameter, double wallThickness)
        {
            this._diameter = diameter;
            this._wallThickness = wallThickness;
            setParameters();
        }

        public objectRoundTube() : this(10.0,1.0) { }       

        
        

        public override string Name { get; set; }

        protected override double calculateSquare()
        {
            return Math.PI * _wallThickness * (_diameter - _wallThickness);
        }
    }
}
