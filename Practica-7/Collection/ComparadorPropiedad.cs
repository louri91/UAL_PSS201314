using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Collection
{
    public class ComparadorPropiedad<T> : IComparer<T> where T : IComparable<T>
    {
        private PropertyDescriptor _property;
        private bool _esAscendente;

        private int ComparaPropiedades(T x, T y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            string valueX = _property.GetValue(x).ToString();
            string valueY = _property.GetValue(y).ToString();
            return (valueX.CompareTo(valueY));
        }

        public ComparadorPropiedad(string nombrePropiedad)
            : this(nombrePropiedad, true)
        {

        }

        public ComparadorPropiedad(string nombePropiedad, bool esAscendente)
        {
            _esAscendente = esAscendente;
            _property = Coleccion<T>.GetProperty(nombePropiedad);
            if (_property == null)
                throw new MissingFieldException("Propiedad" + nombePropiedad + "nula");
        }

        public int Compare(T x, T y)
        {
            if (_esAscendente) return ComparaPropiedades(x, y);
            else return -ComparaPropiedades(x, y);
        }

    }

}
