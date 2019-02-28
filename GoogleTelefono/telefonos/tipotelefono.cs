using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GoogleTelefono.telefonos
{
   public abstract class tipotelefono
    {
      protected  string descripcion = "telefono desconocido";
        public virtual string Descripcion()
        {
            return descripcion;
        }
        public  abstract double Precio();
    }
}
