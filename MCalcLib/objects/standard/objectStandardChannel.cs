using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.classes;
using MCalcLib.attributes;
using MCalcLib.interfaces;
using MCalcLib.exceptions;

namespace MCalcLib.objects
{
    [ItemProperties(DefaultName = @"Швеллер стандартный")]
    public class objectStandardChannel:objectStandardItemBase
    {
        /// <summary>
        /// Высота, мм
        /// </summary>
        [Bound(StandardName="h",Description="Высота, мм")]
        public double Height { get; set; }

        /// <summary>
        /// Ширина, мм
        /// </summary>
        [Bound(StandardName = "a", Description = "Ширина, мм")]
        public double Width { get; set; }

        /// <summary>
        /// Толщина стенки, мм
        /// </summary>
        [Bound(StandardName="s",Description="Толщина стенки, мм")]
        public double WallThickness { get; set; }


        public objectStandardChannel()
        {
            Standard standard = Standard.Init<objectStandardChannel>();
            ApplyStandard(standard);
        }

        public objectStandardChannel(Standard standard)
        {
            ApplyStandard(standard);
        }

        #region --objectStandardItemBase members--
          public override string Name {get;set;}

          public override void ApplyStandard(Standard Standard)
          {
              StandardValidator<objectStandardChannel> validator = new StandardValidator<objectStandardChannel>();
              if (validator.Validate(Standard) == ValidationResult.Success)
              {
                  this.Height = Standard.Bounds["h"];
                  this.Width = Standard.Bounds["a"];
                  this.WallThickness = Standard.Bounds["s"];
                  base.ApplyStandard(Standard);
              }
              else
                  throw new InvalidStandardException();
              
          }
        #endregion

    }
}
