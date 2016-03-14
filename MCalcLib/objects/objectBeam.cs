using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.interfaces;
using MCalcLib.classes;
using MCalcLib.attributes;
using MCalcLib.exceptions;

namespace MCalcLib.objects
{
    [ItemProperties(DefaultName=@"Балка двутавровая")]
    public class objectBeam:objectItemBase,IStandardised
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

        #endregion

        #region --Private--

        Standard standard = Standard.Init<objectBeam>();

        private ValidationResult validateStandard()
        {
            var result = ValidationResult.Failure;

            return result;
        }

        #endregion


        #region --IStandardised members--
        /// <summary>
        /// Применить стандартные настройки параметров
        /// </summary>        
        /// <param name="standard">Экземпляр стандарта</param>
        /// <remarks>Если стандарт не проходит валидацию - выбрасывается исключение</remarks>
        /// <exception cref="InvalidStandardException"/>
        public void ApplyStandard(Standard standard)
        {
            StandardValidator<objectBeam> validator = new StandardValidator<objectBeam>();
            //if standard not null and valid
            var validationResult=validator.Validate(standard);
            if(validationResult==ValidationResult.Success)
            {
                this.Height = (double)standard.Bounds["h"];//.BoundProperties["h"];
                this.ShelfWidth = (double)standard.Bounds["b"];
                this.WebThickness = (double)standard.Bounds["S"];
                this.AverageShelfThickness = (double)standard.Bounds["t"];
                this.standard = standard;
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
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override double GetSquare()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
