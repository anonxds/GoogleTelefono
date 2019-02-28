using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTelefono.telefonos.Especificaciones
{
    class Patallas : tipotelefono
    {
        tipotelefono _tipotelefono;
        public Patallas(tipotelefono tipotelefono)
        {
            this._tipotelefono = tipotelefono;
        }
        public override string Descripcion()
        {
            return "Una simple pantalla";
        }
        public override double Precio()
        {
            return 50;
        }
    }
}
