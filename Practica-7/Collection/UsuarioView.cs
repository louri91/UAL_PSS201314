using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingCollection
{
    public class UsuarioView : Object, IUsuarioView, IEqualityComparer, IComparable,
      IEquatable<UsuarioView>, IEqualityComparer<UsuarioView>, IComparable<UsuarioView>
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string palabraPaso { get; set; }
        public string categoria { get; set; }

        public UsuarioView(int id, string nombre, string palabraPaso, string categoria)
        {
            this.id = id.ToString();
            this.nombre = nombre;
            this.palabraPaso = palabraPaso;
            this.categoria = categoria;
        }
        public UsuarioView()
        {
      
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string PalabraPaso
        {
            get
            {
                return palabraPaso;
            }
            set
            {
                this.palabraPaso = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                this.categoria = value;
            }
        }

        public new bool Equals(object x, object y)
        {
            return x == y;
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            if (this.id == null) return "".GetHashCode();
            return this.id.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            UsuarioView a = obj as UsuarioView;
            if (int.Parse(this.id) == int.Parse(a.id)) return 0;
            if (int.Parse(this.id) > int.Parse(a.id)) return 1;
            if (int.Parse(this.id) < int.Parse(a.id)) return -1;
            if (a == null) return 1;
            return 0;
        }

        public bool Equals(UsuarioView other)
        {
            //If ReferenceEquals(null,obj)
            if (ReferenceEquals(null, other)) return false;
            if (this.id == other.id)
                return true;
            if (other == null)
                return false;
            if (GetType() != other.GetType())
                return false;
            //UsuarioView other = (UsuarioView) obj;
            if (categoria == null)
            {
                if (other.categoria != null)
                    return false;
            }
            else if (!categoria.Equals(other.categoria))
                return false;
            if (id == null)
            {
                if (other.id != null)
                    return false;
            }
            else if (!id.Equals(other.id))
                return false;
            if (nombre == null)
            {
                if (other.nombre != null)
                    return false;
            }
            else if (!nombre.Equals(other.nombre))
                return false;
            if (palabraPaso == null)
            {
                if (other.palabraPaso != null)
                    return false;
            }
            else if (!PalabraPaso.Equals(other.palabraPaso))
                return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            UsuarioView other = obj as UsuarioView;
            if (other == null) return false;
            else return this.Equals(other);
        }

        public bool Equals(UsuarioView x, UsuarioView y)
        {
            if (x == null && y == null) return true;
            if (int.Parse(x.id) == int.Parse(y.id) && x.nombre == y.nombre && x.palabraPaso == y.palabraPaso
             && x.categoria == y.categoria) return true;
            return x.Equals(y);
        }

        public int GetHashCode(UsuarioView obj)
        {
            return int.Parse(obj.id);
        }

        public int CompareTo(UsuarioView other)
        {
            if (other == null)
            {
                return 1;
            }
            return id.CompareTo(other.id);
        }

        public int Compare(UsuarioView other, UsuarioView other2)
        {
            if (other == null && other2 == null) return 0;
            if (other2 == null) return 1;
            if (other == null) return -1;
            if (int.Parse(other.id) == int.Parse(other2.id)) return 0;
            if (int.Parse(other.id) < int.Parse(other2.id)) return -1;
            if (int.Parse(other.id) > int.Parse(other2.id)) return 1;
            return 0;
        }

        //escritura del operador estático de igualdad
        public static bool operator ==(UsuarioView u1, UsuarioView u2)
        {
            if (ReferenceEquals(null, u1) && ReferenceEquals(null, u2)) return true;
            if (ReferenceEquals(null, u1) || ReferenceEquals(null, u2)) return false;

            return u1.Id == u2.Id;
        }


        //escritura del operador estático de des-igualdad
        public static bool operator !=(UsuarioView u1, UsuarioView u2)
        {
            return !(u1 == u2);
        }

        public static bool operator >(UsuarioView objV1, UsuarioView objV2)
        {
            if (ReferenceEquals(null, objV2))
            {
                if (ReferenceEquals(null, objV1))
                    return false;
                return true;
            }
            if (ReferenceEquals(null, objV1)) return false;
            int value1 = int.Parse(objV1.Id);
            int value2 = int.Parse(objV2.Id);
            return objV1.CompareTo(objV2) == 1;
        }

        public static bool operator <(UsuarioView objV1, UsuarioView objV2)
        {
            if (ReferenceEquals(null, objV1))
            {
                if (ReferenceEquals(null, objV2))
                    return false;
                return true;
            }
            if (ReferenceEquals(null, objV2)) return false;
            //return int.Parse(objV1.Id) < int.Parse(objV2.Id);
            int value1 = int.Parse(objV1.Id);
            int value2 = int.Parse(objV2.Id);
            if (value1.CompareTo(value2) == -1) return true;
            return false;
        }

        public static bool operator <=(UsuarioView objV1, UsuarioView objV2)
        {
            if (ReferenceEquals(null, objV1)) return true;
            if (ReferenceEquals(null, objV2)) return false;
            int value1 = int.Parse(objV1.Id);
            int value2 = int.Parse(objV2.Id);
            if (value1.CompareTo(value2) == -1 || value1.CompareTo(value2) == 0) return true;
            return false;
        }
        public static bool operator >=(UsuarioView objV1, UsuarioView objV2)
        {
            if (ReferenceEquals(null, objV2)) return true;
            if (ReferenceEquals(null, objV1)) return false;
            int value1 = int.Parse(objV1.Id);
            int value2 = int.Parse(objV2.Id); ;
            if (value1.CompareTo(value2) == 1 || value1.CompareTo(value2) == 0) return true;
            return false;
        }
    }
}
