using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.classes;
using MCalcLib.interfaces;
using System.Diagnostics;

namespace MCalcLib.objects
{
    public abstract class objectStandardItemBase:objectItemBase,IStandardised
    {
        public Standard Standard { get; set; }

        protected objectStandardItemBase() { }

        protected objectStandardItemBase(string Name):this(Name,null){}

        protected objectStandardItemBase(Standard standard):this(String.Empty,standard){}

        protected objectStandardItemBase(string Name, Standard Standard)
        {
            if(!String.IsNullOrEmpty(Name))  this.Name = Name;
            if(Standard!=null)               this.ApplyStandard(Standard);
        }



        protected abstract void ApplyStandard(Standard Standard);
        
    }
}
