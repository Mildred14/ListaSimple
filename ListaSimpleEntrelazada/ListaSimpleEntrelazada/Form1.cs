using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimpleEntrelazada
{
    public partial class LISTAENTRELAZADA : Form
    {
        public LISTAENTRELAZADA()
        {
            InitializeComponent();
        }
        Lista l = new Lista();
        int codigo;
        string nombre;
        int cantidad;
        int precio;
        Nodo n1;

        private void Agregar_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);
            nombre = textBox2.Text;
            cantidad = Convert.ToInt32(textBox3.Text);
            precio = Convert.ToInt32(textBox4.Text);
            n1 = new Nodo(codigo, nombre, cantidad, precio);
            l.agregar(n1);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
     
        
            codigo = Convert.ToInt32(textBox1.Text);
            l.eliminar(codigo);
        }

        private void INSERTAR_Click(object sender, EventArgs e)
        {
           int codigo = Convert.ToInt32(textBox1.Text);
           string nombre = textBox2.Text;
           int cantidad = Convert.ToInt32(textBox3.Text);
           int precio = Convert.ToInt32(textBox4.Text);
            int posicion = int.Parse(textBox6.Text);

          l.insertar(new Nodo(codigo, nombre, cantidad, precio), posicion);
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            Nodo n1;
            int b = Convert.ToInt32(textBox6.Text);
            n1 = l.buscar(b);
            if (n1 != null)
            {
                textBox5.Text = n1.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text += l.lista();
        }

        
    }
}
