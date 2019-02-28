using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTelefono.telefonos
{
    class Iphone : tipotelefono
    {
        public Iphone()
        {
            descripcion = "Iphone";
        }

        public override double Precio()
        {
            return 1600;
        }
    }
}
