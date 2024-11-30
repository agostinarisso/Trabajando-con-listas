using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5EJ3
{
    public partial class Form1 : Form
    {
        Pila _miPila = new Pila(); // permite usar el objeto pila en todo el formulario
        public Form1()
        {
            InitializeComponent();
        }

        private void ApilarExpediente_Click(object sender, EventArgs e)
        {
            Nodo unNuevoNodo = new Nodo();
            unNuevoNodo.Nombre = txtNombre.Text;
            _miPila.Apilar(unNuevoNodo);

            MostrarPila();
        }

        void MostrarPila()
        {
            listMiPila.Items.Clear();

            if (_miPila.Tope() != null)
            {
                MostrarNodoEnLista(_miPila.Tope());
            }

           

        }

        void MostrarNodoEnLista (Nodo unNodo)
        {
            listMiPila.Items.Add(unNodo.Nombre);

            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnLista(unNodo.Siguiente);
            }
        }

        private void listMiPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            _miPila.Desapilar();
            MostrarPila();
        }
    }
}
