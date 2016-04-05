using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.classes
{
    /// <summary>
    /// Список стандартов
    /// </summary>
    public class StandardsList:IEnumerable, IEnumerator
    {
        Standard[] standards = new Standard[100];
        int index = -1;
        int currentArraySize = 100;
        const int arrayGrowSize = 100;
        int counter = 0;

        public  int Length { get {return index;} }
        public  int Capacity {get {return currentArraySize;} }

        public int Count()
        {
            return index + 1;
        }

        public int Add(Standard standard)
        {

            if (index == standards.Length - 1)
                expandArray();

            standards[++index] = standard;

            counter++;
            return index;
        }

        public int Add(Standard standard, int index)
        {
            if (index > this.index)
                throw new IndexOutOfRangeException();

            standards[index] = standard;
            counter++;
            return index;
        }

        public void Remove(int index)
        {
            if (index == this.index)
                RemoveLast();
            else
            {
                standards[index] = null;
                reindexArray();
            }
            
        }

        private void reindexArray()
        {
            
        }

        public void RemoveLast()
        {
            standards[index] = null;
            index--;
        }

        private void expandArray()
        {
            currentArraySize+=arrayGrowSize;
            Standard[] locStandards = new Standard[currentArraySize];
            standards.CopyTo(locStandards, 0);
            standards = locStandards;
        }

        public Standard this[int index]
        {
            get
            {
                
                if (index > this.index)
                    return null;
                else
                    return standards[index]; 
            }
            set { this.Add(value, index); }
        }

        #region IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerator
        public object Current
        {
            get { return standards[index]; }
        }

        public bool MoveNext()
        {
            if(index==standards.Length-1)
            {
                Reset();
                return false;
            } 
            else
            {
                index++;
                return true;
            }

        }

        public void Reset()
        {
            index = -1;
        }
        #endregion
    }
}
