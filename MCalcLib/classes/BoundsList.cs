using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.classes
{
    /// <summary>
    /// Список габаритных параметров с индексным доступом
    /// </summary>
    
        //TODO: Реализовать IEnumerable
    public class BoundsList//:IEnumerable
    {
        private Hashtable bounds = new Hashtable();

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

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
