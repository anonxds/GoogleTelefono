using GoogleTelefono.telefonos;
using GoogleTelefono.telefonos.Especificaciones;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTelefono
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            telefonos.Items.Add("Iphone");
            telefonos.Items.Add("Huawie");
            telefonos.Items.Add("Pixel");
            listamemorias.Items.Add("8gb");
            listamemorias.Items.Add("16gb");
            listamemorias.Items.Add("32gb");
            Listacamaras.Items.Add("8mpx");
            Listacamaras.Items.Add("16mpx");
            Listacamaras.Items.Add("24mpx");
         
        }

        private void Listacamaras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   Typotelefono();
            switch (telefonos.Text)
            {
                case "Pixel":
                    tipotelefono phone = new Pixel();
                    tipocamara(phone, Listacamaras);
                    break;
                case "Huawie":
                     phone = new Huawie();
                    tipocamara(phone, Listacamaras);
                    break;
                case "Iphone":
                     phone = new Iphone();
                    tipocamara(phone, Listacamaras);
                    break;
            }
            preciocambio();
        }
        public void preciocambio()
        {
            double preciofinal = double.Parse(lblpreciocamaras.Text) + double.Parse(lblpreciomemorias.Text) + double.Parse(label6.Text) + double.Parse(lblpreciopantalla.Text);
            lblprecio.Text = Convert.ToString(preciofinal);
        }

        public void tipocamara(tipotelefono tel,ComboBox Listacamaras)
        {
          
            switch (Listacamaras.Text)
            {
                case "8mpx":
                    tel = new camara8(tel);
              //      lblpreciocamaras.Text = Convert.ToString(tel.Precio());
                    break;
                case "16mpx":
                    tel = new camara16(tel);
                //    lblpreciocamaras.Text = Convert.ToString(tel.Precio());
                    break;
                case "24mpx":
                    tel = new camara24(tel);
                 
                    break;
            }

            label4.Text = Convert.ToString(tel.Precio());

            lbldescripcioncamara.Text = tel.Descripcion();
            lblpreciocamaras.Text = Convert.ToString(tel.Precio());
          
        }
        public void tipomemoria(tipotelefono tel, ComboBox Listacamaras)
        {

            switch (Listacamaras.Text)
            {
                case "8gb":
                    tel = new Memoria8(tel);
                    //      lblpreciocamaras.Text = Convert.ToString(tel.Precio());
                    break;
                case "16gb":
                    tel = new Memoria16(tel);
                    //    lblpreciocamaras.Text = Convert.ToString(tel.Precio());
                    break;
                case "32gb":
                    tel = new memoria24(tel);

                    break;
            }

            label5.Text = Convert.ToString(tel.Precio());
            lbldescripcionmemorias.Text = tel.Descripcion();
            lblpreciomemorias.Text = Convert.ToString(tel.Precio());

        }

        private void listamemorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (telefonos.Text)
            {
                case "Pixel":
                    tipotelefono phone = new Pixel();
                    tipomemoria(phone, listamemorias);
                    break;
                case "Huawie":
                     phone = new Huawie();
                    tipomemoria(phone, listamemorias);
                    break;
                case "Iphone":
                     phone = new Iphone();
                    tipomemoria(phone, listamemorias);
                    break;
            }
            preciocambio();
        }

        private void telefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Typotelefono();
            habilitar();
            
        }
        public void Typotelefono()
        {
              
            switch (telefonos.Text)
            {
                case "Pixel":
                    tipotelefono phone = new Pixel();
                    lblnombretel.Text = phone.Descripcion();
                    lblprecio.Text = "Precio: " + Convert.ToString(phone.Precio());
                    label6.Text = Convert.ToString(phone.Precio());
                    //  tipocamara(phone, Listacamaras);

                    break;
                case "Huawie":
                     phone = new Huawie();
                    lblnombretel.Text = phone.Descripcion();
                    lblprecio.Text = "Precio: " + Convert.ToString(phone.Precio());
                    label6.Text = Convert.ToString(phone.Precio());
                    break;
                case "Iphone":
                     phone = new Iphone();
                    lblnombretel.Text = phone.Descripcion();
                    lblprecio.Text = "Precio: " + Convert.ToString(phone.Precio());
                    label6.Text = Convert.ToString(phone.Precio());
                    break;
            }
            preciocambio();
            
        }

        private void cantidadcamaras_ValueChanged(object sender, EventArgs e)
        {
            lblpreciocamaras.Text = Convert.ToString(Convert.ToDouble(cantidadcamaras.Value) * double.Parse(label4.Text));
            preciocambio();
        }

        private void cantidadmemorias_ValueChanged(object sender, EventArgs e)
        {
            lblpreciomemorias.Text = Convert.ToString(Convert.ToDouble(cantidadmemorias.Value) * double.Parse(label5.Text));
            preciocambio();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (telefonos.Text)
            {
                case "Pixel":
                    tipotelefono phone = new Pixel();
                    phone = new Patallas(phone);
                    pantalla(phone, lblpreciopantalla);
                    //  tipocamara(phone, Listacamaras);

                    break;
                case "Huawie":
                    phone = new Huawie();
                    phone = new Patallas(phone);
                    pantalla(phone, lblpreciopantalla);
                    break;
                case "Iphone":
                    phone = new Iphone();
                    phone = new Patallas(phone);
                    pantalla(phone, lblpreciopantalla);
                    break;
            }
            preciocambio();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if(txtcorreo.Text == "")
            {
                MessageBox.Show("[Tu mensaje]");
            }
            else
            {
                EnviarMensaje();
            }
     
        }
        private void habilitar()
        {
         txtcorreo.Enabled=   listamemorias.Enabled = Listacamaras.Enabled = textBox1.Enabled = cantidadcamaras.Enabled = cantidadmemorias.Enabled = btnenviar.Enabled = true;
        }
        private void pantalla(tipotelefono v,Label precio)
        {
            precio.Text = Convert.ToString(v.Precio() * double.Parse(textBox1.Text));
        }
        private void EnviarMensaje()
        {
            try
            {
                Document ticket = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                MemoryStream memoryStream = new MemoryStream();
              PdfWriter wri = PdfWriter.GetInstance(ticket, memoryStream);
                ticket.AddTitle("Recibo");
                ticket.AddCreator("Phone2Go");
                ticket.Open();
                ticket.Add(new Paragraph(lblnombretel.Text +
                    " Camara " + lblpreciocamaras.Text +
                    " Cantidad " + cantidadcamaras.Value +
                    " Precio " + lblpreciocamaras.Text +
                    " Descripcion " + lbldescripcioncamara +
                    " Memoria " + lblpreciomemorias.Text +
                    " Cantidad " + cantidadmemorias.Value +
                    " Precio:  " + lblpreciomemorias.Text + "\n" +
                    " Descripcion " + lbldescripcion.Text +
                    " Pantalla Precio: " + lblpreciopantalla.Text +
                    " Precio: " + lblprecio.Text));

                wri.CloseStream = false;
                ticket.Close();
                memoryStream.Position = 0;
              
                //

                MailMessage mail = new MailMessage("orlandosanch3z@gmail.com", txtcorreo.Text, "Ticket de compra","Recibo");
                mail.Attachments.Add(new Attachment(memoryStream, "Recibo.pdf"));
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("orlandosanch3z@gmail.com", "bejeweled2012");
                client.EnableSsl = true;
                client.Send(mail);
                //      string query = string.Format("insert into Ventas (Telefono,Precio,Correo,Fecha) values('{0}','{1}','{2}','{3}')", lblspecs.Text += lblstorage.Text += lblacc.Text, lblprecio.Text, txtemail.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                //     s.Exe(query);

                MessageBox.Show("Mensaje enviado");

            }
            catch
            {
                MessageBox.Show("Algo sucedio");
            }
        }//un simple y sencillo metodo para enviar correo
    }
}
