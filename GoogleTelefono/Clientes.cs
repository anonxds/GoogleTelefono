using GoogleTelefono.Observer;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        SujetoConcreto s = new SujetoConcreto();
        private void btnenviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcorreo.Text == "" || txtnombre.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los datos");
                }
                else
                {
                 //   MailMessage mail = new MailMessage("bejeweler2@gmail.com", textBox1.Text, "Reticula", "Listado de patos");
              //      string query = string.Format("insert into Subcritores (Nombre,Correo) values ('{0}','{1}')", txtemail.Text, textBox1.Text);
                //    sq.Exe(query);
                    s.Attach(new Concreto(txtnombre.Text, s, txtcorreo.Text));
                    //  s.Notifica();
                    cbusuarios.Items.Add(txtnombre.Text);
                    txtnombre.Text = txtcorreo.Text = "";
                    btnenviar.Enabled = false;
                    
                    MessageBox.Show("Se suscribo el usuario");

                }

            }
            catch
            {
                MessageBox.Show("Correo no valido");
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
       //     string query = string.Format("delete from Subcritores where Nombre = '{0}'", comboBox1.Text);
         //   sq.Exe(query);
            s.Deataach(cbusuarios.SelectedIndex);
            s.Estado = txtcorreo.Text;
            cbusuarios.Items.RemoveAt(cbusuarios.SelectedIndex);
            btnquitar.Enabled = false;
           
        }

        private void txtofertas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnotificar_Click(object sender, EventArgs e)
        {
            if (txtofertas.Text == "")
            {
                MessageBox.Show("Favor de escribir las promociones");
            }
            else
            {
                s.Notifica(txtofertas);
            }
        }
    }
}
