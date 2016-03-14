using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.classes
{
    public class StandardGroup
    {
        /// <summary>
        /// Название группы стандартов
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание группы
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Список стандартов
        /// </summary>
        public List<Standard> Standards { get; set; }
    }
}
