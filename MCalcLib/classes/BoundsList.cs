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
    public class BoundsList:IEnumerable
    {
        //private Hashtable bounds = new Hashtable();
        //private HashSet<double> bounds = new HashSet<double>();
        private List<Bound> bounds = new List<Bound>();
        

        public bool ContainsKey(string key)
        {
            return bounds.Count>0 && bounds.Exists(p => p.key == key);
        }

        public double this[string key]
        {
            get
            {
                var val = from bound in bounds
                          where bound.key == key
                          select bound.value;
                return val.FirstOrDefault();

            }
            set
            {
                int index = bounds.FindIndex(p => p.key == key);

                if(index>=0)
                {
                    bounds[index] = new Bound{key=key,value=value};
                    
                }
                else
                    bounds.Add(new Bound { key=key, value=value}); 
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)bounds).GetEnumerator();
        }

        
    }
}
