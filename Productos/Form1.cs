using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pro = Convert.ToInt32(textBox7.Text);
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                var copro = cliente.ObtenerProducto(pro);
                var no_empleado = copro.Codigo_Producto;
                var nombre = copro.Nombre;
                var apellido_p = copro.Cantidad;
                var apellido_m = copro.Precio;
                var empresa_perteneciente = copro.Empresa_Proviene;
                var departamento = copro.Existencia_Almacen;

                textBox1.Text = copro.Codigo_Producto.ToString();
                textBox2.Text = copro.Nombre.ToString();
                textBox3.Text = copro.Cantidad.ToString();
                textBox4.Text = copro.Precio.ToString();
                textBox5.Text = copro.Empresa_Proviene.ToString();
                textBox6.Text = copro.Existencia_Almacen.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
