﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.interfaces;
using MCalcLib.classes;
using MCalcLib.attributes;
using MCalcLib.exceptions;

namespace MCalcLib.objects
{
    [ItemProperties(DefaultName = @"Балка двутавровая")]
    public class objectBeam : objectStandardItemBase
    {
        #region --Public--

        [Bound(StandardName = "h", Description = "Высота двутавра")]
        public double Height { get; set; }

        [Bound(StandardName = "b", Description = "Ширина полки")]
        public double ShelfWidth { get; set; }

        [Bound(StandardName = "S", Description = "Толщина стенки")]
        public double WebThickness { get; set; }

        [Bound(StandardName = "t", Description = "Средняя толщина полки")]
        public double AverageShelfThickness { get; set; }

        public  double DensityWeight { get; set; }

        #endregion

        #region --Private--

       // Standard standard;// = Standard.Init<objectBeam>();
        string name = String.Empty;

        #endregion

        #region --CTOR--
        public objectBeam()
        {
            Standard standard = Standard.Init<objectBeam>();
            ApplyStandard(standard);
        }

        public objectBeam(Standard standard)
        {
            ApplyStandard(standard);
        }


        #endregion

        #region --IStandardised members--
        /// <summary>
        /// Применить стандартные настройки параметров
        /// </summary>        
        /// <param name="standard">Экземпляр стандарта</param>
        /// <remarks>Если стандарт не проходит валидацию - выбрасывается исключение</remarks>
        /// <exception cref="InvalidStandardException"/>        
        public override void ApplyStandard(Standard standard)
        {            
            StandardValidator<objectBeam> validator = new StandardValidator<objectBeam>();
            //if standard not null and valid
            var validationResult = validator.Validate(standard);

            System.Diagnostics.Debug.Assert(validationResult != ValidationResult.Undefined, @"Validation result is undefined!!!");

            if (validationResult == ValidationResult.Success)
            {
                this.Height = standard.Bounds["h"];//.BoundProperties["h"];
                this.ShelfWidth = standard.Bounds["b"];
                this.WebThickness = standard.Bounds["S"];
                this.AverageShelfThickness = standard.Bounds["t"];
                this.DensityWeight = standard.StandardDensityWeight;
                base.ApplyStandard(standard);
                
            }
            else
            {
                throw new InvalidStandardException(String.Format(@"Ошибка применения стандарта {0}!", standard.Name));
            }

        }

        #endregion


        #region --objectItemBase members--
        public override string Name
        {
            get
            {
                if (String.IsNullOrEmpty(this.name))
                {
                    var attr = this.GetType().GetCustomAttributes(typeof(ItemPropertiesAttribute), false)[0] as ItemPropertiesAttribute;
                    if (attr != null)
                        this.name = attr.DefaultName;
                }
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        
        #endregion
    }
}
