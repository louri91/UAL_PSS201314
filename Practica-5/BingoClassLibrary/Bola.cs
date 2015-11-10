using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bingo 
{
    public class Bola:IEqualityComparer<Bola>,IEquatable<Bola>
    {
        public int _numero;
        public int Numero
        {
            get { return _numero; }
            set
            {
                if (value < 1 || value > 90) throw new
                ArgumentOutOfRangeException("Out of Range Index");
                else _numero = value;
            }
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Bola);
        }
        public override int GetHashCode()
        {
            return this.Numero.GetHashCode();
        }
        public bool Equals(Bola x, Bola y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return
            false;
            else return (x.Numero == y.Numero);
        }
        public int GetHashCode(Bola obj)
        {
            return obj.Numero.GetHashCode();
        }
        public bool Equals(Bola other)
        {
            return Equals(this, other);
        }
        public static bool operator ==(Bola a, Bola b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Bola a, Bola b)
        {
            return !a.Equals(b);
        }
    }
}
