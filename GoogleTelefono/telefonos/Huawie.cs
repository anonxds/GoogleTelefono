using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTelefono.telefonos
{
    class Huawie : tipotelefono
    {
        public Huawie()
        {
            descripcion = "Huawie";
        }

        public override double Precio()
        {
            return 1200;
        }
    }
}
