using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTelefono.telefonos.Especificaciones
{
    class camara24 : tipotelefono
    {
        tipotelefono _tipotelefono;
        public camara24(tipotelefono tipotelefono)
        {
            this._tipotelefono = tipotelefono;
        }
        public override string Descripcion()
        {
            return "camara de 24mpx";
        }

        public override double Precio()
        {
            return 80;
        }
    }
}
