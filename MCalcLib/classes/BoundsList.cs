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
        //private HashSet<double> bounds = new HashSet<double>();
        

        public double this[string key]
        {
            get { return Double.Parse(this.bounds[key].ToString()); }
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
