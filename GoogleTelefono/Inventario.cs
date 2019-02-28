using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTelefono
{
    public partial class Inventario : Form
    {
        Sqlite s = new Sqlite();
        public Inventario()
        {
            InitializeComponent();
            s.dgrid(dataGridView1, "select * from Inventario");
        }
    }
}
