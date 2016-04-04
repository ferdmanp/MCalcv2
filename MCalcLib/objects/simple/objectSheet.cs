using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.attributes;

namespace MCalcLib.objects.simple
{
    [ItemProperties(DefaultName=@"Лист")]
    public class objectSheet:objectStripe 
    {
        protected objectSheet() : base()
        {
            Name = @"Квадрат";
        }

        public objectSheet(int width, string name) : base(width, width, name) { }

        public objectSheet(int width) : this(width, @"Квадрат") { }
                

        public override string Name {get; set;}      
    }
}
