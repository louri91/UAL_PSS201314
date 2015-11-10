using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class RecorridoSecuencia<T> where T : IComparable<T>
    {
        private IEnumerable<T> _secuencia;

        public RecorridoSecuencia(IEnumerable<T> secuencia)
        {
            _secuencia = secuencia;
        }

        public IEnumerable<T> YieldAdelante()
        {
            int count = _secuencia.Count();
            for (int i = 0; i < count; i++)
            {
                yield return _secuencia.ElementAt(i);   //yield crea la estructura del enumerador

            }
        }

        public IEnumerable<T> YieldAtras()
        {
            int count = _secuencia.Count();
            for (int i = count - 1; i > -1; i--)
            {
                yield return _secuencia.ElementAt(i);
            }
        }

        public IEnumerable<T> YieldAscendente(string campo)
        {
            List<T> orderedList = new List<T>(_secuencia);
            orderedList.Sort(new ComparadorPropiedad<T>(campo));
            foreach (T t in orderedList)
                yield return t;
        }

        public IEnumerable<T> YieldDescendente(string campo)
        {
            List<T> orderedList = new List<T>(_secuencia);
            orderedList.Sort(new ComparadorPropiedad<T>(campo, false));
            foreach (T t in orderedList)
                yield return t;
        }

        public IEnumerable<T> EnumeradorParametro(IEnumerator<T> enumerator)
        {
            //List<T> list = new List<T>();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
                //list.Add(enumerator.Current);
            }
            // return list;
        }

        public IEnumerable<T> EnumerableParametro(IEnumerable<T> enumerable)
        {
            return enumerable;
        }
    }

}

