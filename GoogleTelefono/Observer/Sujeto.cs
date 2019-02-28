using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTelefono.Observer
{
    class Sujeto
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Deataach(int i)
        {
            try
            {
                _observers.RemoveAt(i);
            }
            catch
            {
                MessageBox.Show("No hay usuarios por quitar");
            }
        }
        public void Notifica(TextBox s)
        {
            foreach (Observer o in _observers)
            {
                o.Update(s);
            }
        }
        public void Popular(ComboBox cb)
        {
            cb.Items.Add(_observers);
        }
    }
    class SujetoConcreto : Sujeto
    {
        private string _EstadoSujeto;
        public string Estado
        {
            get { return _EstadoSujeto; }
            set { _EstadoSujeto = value; }
        }
    }
}

