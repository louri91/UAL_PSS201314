using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Collection
{
    public class Coleccion<T> : List<T>,IEnumerable<T>
    {
        public Coleccion(IEnumerable<T> secuencia):base(secuencia)
        {
        }
        public Coleccion(){}
        public new T this[int index]
        {
            get
            {
                return base[index];
            }
        }
        
        /*La clase tiene que tener una propiedad indexador,
        que permita acceder a través de indice (junto con el nombre de la instancia
        de la clase Coleccion) al contenedor de la clase List<T>
        de la cual hereda.*/
   
        public new void Add(T item) 
        {
            base.Add(item);
        }
        public new bool Remove(T item) 
        {
            return base.Remove(item);
        }
        public new bool Contains(T item)
        {
            return base.Contains(item);
        }//Determina si item se encuentra en la colección.

        public new void Clear()
        {
            base.Clear();
        } //Quita todos los elementos de la colección.

        public new int Count 
        {
            get {return base.Count;} 
        } //Devuelve el número de elementos de la colección. 

        public new void Sort(IComparer<T> comparer)
        {
            base.Sort(comparer);
        } //Ordena los elementos de la colección en base al parámetro   

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return base.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return base.GetEnumerator();
        }

        public static PropertyDescriptor GetProperty(string name)
        {
            T item = (T)Activator.CreateInstance(typeof(T));
            PropertyDescriptor propName = null;
            foreach (PropertyDescriptor propDesc in TypeDescriptor.GetProperties(item))
            {
                if (propDesc.Name.Contains(name))
                    propName = propDesc;
            }
            return propName;
        }
    }
}
