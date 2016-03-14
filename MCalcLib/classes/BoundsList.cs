using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.classes
{
    public class BoundsList
    {
        private Hashtable bounds;

        public object this[string key]
        {
            get { return this.bounds[key]; }
            set
            {
                if (bounds.ContainsKey(key))
                    bounds[key] = value;
                else
                    bounds.Add(key, value);
            }
        }
    }
}
