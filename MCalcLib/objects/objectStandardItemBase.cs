using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.classes;
using MCalcLib.interfaces;

namespace MCalcLib.objects
{
    public abstract class objectStandardItemBase:objectItemBase,IStandardised
    {
        public abstract Standard Standard { get; set; }

        protected objectStandardItemBase()
        {
            
        }

        protected objectStandardItemBase(string Name)
        {
            this.Name = Name;
        }

        protected objectStandardItemBase(Standard standard)
        {

        }

        protected objectStandardItemBase(string Name, Standard Standard)
        {
            this.Name = Name;
            this.ApplyStandard(Standard);
        }



        protected abstract void ApplyStandard(Standard Standard);
        
    }
}
