using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTelefono.telefonos.Especificaciones
{
    class camara16 : tipotelefono
    {
        tipotelefono _tipotelefono;
        public camara16(tipotelefono tipotelefono)
        {
            this._tipotelefono = tipotelefono;
        }
        public override string Descripcion()
        {
            return "camara de 16mpx";
        }

        public override double Precio()
        {
            return 40;
        }
    }
}
