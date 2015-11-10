using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class EnumeradorAtras<T> : IEnumerator<T>
    {
        private IEnumerable<T> collec;
        private int curIndex;
        private int count;

        public EnumeradorAtras(IEnumerable<T> _collec)
        {
            collec = _collec;
            count = collec.Count();
            curIndex = count;

        }

        public T Current
        {
            get
            {
                if (curIndex < 0 || curIndex >= count) return default(T);
                return (collec.ElementAt(curIndex));
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return this.Current; }
        }

        public bool MoveNext()
        {
            if (--curIndex < count)
            {
                return false;
            }
            else return true;
        }

        public void Reset()
        {
            curIndex = count;
        }

        public void Dispose()
        {

        }
    }
}
