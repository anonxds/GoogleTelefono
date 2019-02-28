using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTelefono.telefonos
{
    public class camara8 : Caracteristicas
    {
        tipotelefono _tipotelefono;
        public camara8(tipotelefono tipotelefono)
        {
            this._tipotelefono = tipotelefono;
        }

        public override string Descripcion()
        {
            return "camara de 8mpx";
        }

        

        public override double Precio()
        {
            return 20; 
        }
    }
}
