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
    /// Квадрат
    /// </summary>
    [ItemProperties(DefaultName = @"Квадрат")]
    public class objectQuadrat : objectStripe
    {
       

        protected objectQuadrat() : base()
        {
            Name = @"Квадрат";
        }

        public objectQuadrat(int width, string name) : base(width, width, name) { }

        public objectQuadrat(int width) : this(width, @"Квадрат") { }
                

        public override string Name {get; set;}


    }
}
