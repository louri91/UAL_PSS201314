using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Collection
{
    public class ComparadorAscendente<T> : IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.CompareTo(y);
        }
    }
}
