using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;
using MCalcLib.classes;
using MCalcLib.exceptions;


namespace MCalcLib.objects
{
    /// <summary>
    /// Лента
    /// </summary>
    [ItemProperties(DefaultName=@"Лента")]
    public class objectStripe:objectSimpleItemBase
    {
        private double _width, _height;

        [Bound(StandardName="a",Description=@"Ширина")]
        public double Width 
        { 
            get
            {
                return _width;
            }
            set 
            {
                _width=value;
                setParameters();
            }
        }

        [Bound(StandardName = "b", Description = @"Высота")]
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
        
        protected objectStripe() : base(@"Лента") { }

        

        public objectStripe(double width, double height, string name)
        {
            if (String.IsNullOrEmpty(name))
                Name=@"Лента";
            else
                Name = name;
            Height = height;
            Width = width;
        }

        public objectStripe(double width, double height):this(width,height,null) { }
        
        private double calculateSquare()
        {
            return _width * _height;
        }

        private void setParameters()
        {
            this.square = calculateSquare();
            this.densityWeight= this.square / 1000000000.0 * 1000 * TEMP_DENSITY;
        }

        public override string Name {get;set;}

        public override string ToString()
        {
            return String.Format(
               @"Type: Stripe" + Environment.NewLine
                 + "Name: {0}" + Environment.NewLine
                 + "Width: {1}" + Environment.NewLine
                 + "Height: {2}" + Environment.NewLine
                 + "Square: {3}" + Environment.NewLine
                 + "DensityWeight: {4}" + Environment.NewLine,
                 Name, Width, Height, Square, DensityWeight
               );

        }

    }
}
