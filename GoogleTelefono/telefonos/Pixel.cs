using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTelefono.telefonos
{
     class Pixel : tipotelefono
    {
        public Pixel()
        {
            descripcion = "Pixel 11";
        }

     

        public override double Precio()
        {
             
            return  999;
        }
    }
}
