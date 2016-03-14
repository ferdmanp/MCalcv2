using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalc.objects
{
    public abstract class ItemBase
    {
        public abstract string Name { get; set; }

        public abstract double DensityWeight { get;  set; }

        public abstract double GetSquare();
    }
}
