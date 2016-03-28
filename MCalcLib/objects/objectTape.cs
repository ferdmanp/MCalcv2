using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;
using MCalcLib.classes;
using MCalcLib.exceptions;


namespace MCalcLib.objects
{
    
    [ItemProperties(DefaultName=@"Лента")]
    public class objectTape:objectSimpleItemBase
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
            }
        }
        
        protected objectTape() : base(@"Лента") { }

        public objectTape(double width, double height, string name)
        {
            if (String.IsNullOrEmpty(name))
                Name=@"Лента";
            else
                Name = name;
            Height = height;
            Width = width;
        }

        public objectTape(double width, double height):this(width,height,null) { }
        
        
        public override string Name {get;set;}
        
    }
}
