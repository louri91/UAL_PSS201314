using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class ComparadorDescendente<T>:IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return y.CompareTo(x);
        }
    
    }
}
