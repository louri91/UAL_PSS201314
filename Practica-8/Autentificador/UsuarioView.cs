using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BindingCollection
{
    public class UsuarioView : IUsuarioView, IEqualityComparer, IComparable,
        IEquatable<UsuarioView>, IEqualityComparer<UsuarioView>,IComparable<UsuarioView>
    {
       public string Id {  get;  set; }
       public  string Nombre {  get;  set; }
       public string PalabraPaso {  get;  set; }
       public  string Categoria {  get;  set; }

        public UsuarioView(int id, string nombre, string palabraPaso, string categoria, string valido)
        {
            this.Id = id.ToString();
            this.Nombre = nombre;
            this.PalabraPaso = palabraPaso;
            this.Categoria = categoria;
            this.esValido = Boolean.Parse(valido);
        }

        public UsuarioView(string p1, string p2, string p3, string p4, string p5)
        {
            // TODO: Complete member initialization
            this.Id = p1;
            this.Nombre = p2;
            this.PalabraPaso = p3;
            this.Categoria = p4;
            this.esValido = Boolean.Parse(p5);
        }

        public UsuarioView()
        {
            this.Id = this.Nombre = this.PalabraPaso = this.Categoria = null;
            this.esValido = false;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            UsuarioView other = obj as UsuarioView;
            if (other == null) return false;
            else return this.Equals(other); 
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public new bool Equals(object x, object y)
        {
            return x == y;
        }

        public int GetHashCode(object obj)
        {
            int prime = 31;
            int result = 1;
            result = prime * result
                    + ((Categoria == null) ? 0 : Categoria.GetHashCode());
            result = prime * result + ((Id == null) ? 0 : Id.GetHashCode());
            result = prime * result + ((Nombre == null) ? 0 : Nombre.GetHashCode());
            result = prime * result
                    + ((PalabraPaso == null) ? 0 : PalabraPaso.GetHashCode());
            return result;
        }

        public int CompareTo(object obj)
        {
            UsuarioView usuario = obj as UsuarioView;
            if (usuario == null)
            {
                return 1;
            }
            return Id.CompareTo(usuario.Id);
        }

        public bool Equals(UsuarioView other)
        {
            //If ReferenceEquals(null,obj)
            if (ReferenceEquals(null, other)) return false;
            if (this.Id == other.Id)
                return true;
            if (other == null)
                return false;
            if (GetType() != other.GetType())
                return false;
            //UsuarioView other = (UsuarioView) obj;
            if (Categoria == null)
            {
                if (other.Categoria != null)
                    return false;
            }
            else if (!Categoria.Equals(other.Categoria))
                return false;
            if (Id == null)
            {
                if (other.Id != null)
                    return false;
            }
            else if (!Id.Equals(other.Id))
                return false;
            if (Nombre == null)
            {
                if (other.Nombre != null)
                    return false;
            }
            else if (!Nombre.Equals(other.Nombre))
                return false;
            if (PalabraPaso == null)
            {
                if (other.PalabraPaso != null)
                    return false;
            }
            else if (!PalabraPaso.Equals(other.PalabraPaso))
                return false;
            return true;
        }
    
        public bool Equals(UsuarioView x, UsuarioView y)
        {
 	        if (x == y)
            {
                return true;
            }
            if (x != y)
            {
                return false;
            }
            return true;
        }

        public int GetHashCode(UsuarioView obj)
        {
            int prime = 31;
            int result = 1;
            result = prime * result + ((Id == null) ? 0 : Id.GetHashCode());
            return result;
        }

        public int CompareTo(UsuarioView other)
        {
            if (other == null)
            {
                return 1;
            }
            return Id.CompareTo(other.Id); 
        }

        //operadores
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

            if (objV1.Id.CompareTo(objV2.Id) == -1) return true;
            return false;
        }

        public static bool operator <=(UsuarioView objV1, UsuarioView objV2)
        {
            if (ReferenceEquals(null, objV1)) return true;
            if (ReferenceEquals(null, objV2)) return false;
            if (objV1.Id.CompareTo(objV2.Id) == -1 || objV1.Id.CompareTo(objV2.Id) == 0) return true;
            return false;
        }
        public static bool operator >=(UsuarioView objV1, UsuarioView objV2)
        {
            if (ReferenceEquals(null, objV2)) return true;
            if (ReferenceEquals(null, objV1)) return false;
            if (objV1.Id.CompareTo(objV2.Id) == 1 || objV1.Id.CompareTo(objV2.Id) == 0) return true;
            return false;
        }

        public int Compare(UsuarioView objV1, UsuarioView objV2)
        {
            if (ReferenceEquals(objV1, objV2)) return 0;
            if (ReferenceEquals(null, objV1)) return -1;
            if (ReferenceEquals(null, objV2)) return 1;
            return objV1.Id.CompareTo(objV2.Id);
        }



        public bool esValido
        {
            get
            {
                return esValido;
            }
            set
            {
                this.esValido=(bool)value;
            }
        }
    }
}
