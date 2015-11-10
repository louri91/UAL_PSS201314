using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class EnumeradorAdelante<T>:IEnumerator<T>
    {
        private IEnumerable<T> collec;
        private int curIndex;
        private int count;

        public EnumeradorAdelante(IEnumerable<T> _collec) 
        {
            collec = _collec;
            curIndex = -1;
            count = collec.Count();
        }

        public T Current
        {
            get {if(curIndex<0|| curIndex>= count) return default(T);
                return (collec.ElementAt(curIndex));
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return this.Current; }
        }

        public bool MoveNext()
        {
            if (curIndex < collec.Count()-1)
            {
                return false;
            }
            else return true;
        }

        public void Reset()
        {
            curIndex = -1;
        }

        public void Dispose()
        {
           
        }
    }
}
