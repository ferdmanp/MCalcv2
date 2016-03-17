using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.objects
{
    abstract class objectSimpleItemBase : objectItemBase
    {
        protected objectSimpleItemBase()
        {

        }

        protected objectSimpleItemBase(string Name)
        {
            this.Name = Name;
        }



        /// <summary>
        /// Возвращает площадь простой фигуры
        /// </summary>
        /// <returns></returns>
        abstract public double GetSquare();
    }
}
