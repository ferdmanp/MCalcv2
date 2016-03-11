using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.classes
{
    public class Standard
    {
        /// <summary>
        /// Название ГОСТа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание ГОСТа
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// таблица габаритных свойств
        /// </summary>
        public Hashtable BoundProperties;

        /// <summary>
        /// Вес 1м погонного
        /// </summary>
        public double DensityWeight { get; set; }
        
    }
}
