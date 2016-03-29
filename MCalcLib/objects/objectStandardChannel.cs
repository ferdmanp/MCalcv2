using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.classes;
using MCalcLib.attributes;
using MCalcLib.interfaces;

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


        #region --objectStandardItemBase members--
          public override string Name {get;set;}

          public override void ApplyStandard(Standard Standard)
          {
              base.ApplyStandard(Standard);
          }
        #endregion

    }
}
