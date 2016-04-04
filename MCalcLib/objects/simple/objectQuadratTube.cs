using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;
using MCalcLib.classes;
using MCalcLib.exceptions;


namespace MCalcLib.objects
{
    [ItemProperties(DefaultName=@"Труба квадратная")]
    public class objectQuadratTube:objectSimpleItemBase
    {


        #region --Private--
        private double _width;
        private double _height;
        private double _wallThickness;

        protected override void setParameters()
        {
            this.square = calculateSquare();
            ///Формула S(m2)*L(m)*Density
            this.densityWeight = this.square / 1000000000.0 * 1000 * TEMP_DENSITY;
        }

        protected override double calculateSquare()
        {
            return 2 * _wallThickness * (_width + _height - 2 * _wallThickness);
        } 
        #endregion

        #region --Bounds--
        [Bound(StandardName = "a", Description = "Ширина, мм")]
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                setParameters();
            }
        }

        [Bound(StandardName = "b", Description = "Высота, мм")]
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                setParameters();
            }
        }

        [Bound(StandardName = "h", Description = "Толщина стенки, мм")]
        public double WallThickness
        {
            get
            {
                return _wallThickness;
            }
            set
            {
                _wallThickness = value;
                setParameters();
            }
        }  
        #endregion

        #region --CTOR--
        public objectQuadratTube() : this(1.0, 1.0, 1.0) { }

        public objectQuadratTube(double width, double height, double wallThickness)
        {
            this._width = width;
            this._height = height;
            this._wallThickness = wallThickness;
            setParameters();

        }    
        #endregion     

        
        

        #region --OVERRIDE--
        public override string Name {get;set; }
        #endregion


    }
}
