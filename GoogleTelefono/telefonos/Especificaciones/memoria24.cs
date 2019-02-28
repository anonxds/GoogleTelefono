using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTelefono.telefonos.Especificaciones
{
    class memoria24 : tipotelefono
    {
        tipotelefono _tipotelefono;
        public memoria24(tipotelefono tipotelefono)
        {
            this._tipotelefono = tipotelefono;
        }
        public override string Descripcion()
        {
            return "Memoria de 24gb";
        }

        public override double Precio()
        {
            return 70;
        }
    }
}
