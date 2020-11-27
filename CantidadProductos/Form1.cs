using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CantidadProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceReference3.Service1Client cliente = new ServiceReference3.Service1Client();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nom = textBox5.Text;
            var can = Convert.ToInt32(textBox6.Text);

            using (ServiceReference3.Service1Client cliente = new ServiceReference3.Service1Client())
            {
                var cant = cliente.ObtenerCantidad(nom, can);
                var nombre = cant.Nombre_Producto;
                var codigo = cant.Codigo_Producto;
                var precio = cant.Precio_Producto;
                var descuento = cant.Total;

                textBox1.Text = cant.Nombre_Producto.ToString();
                textBox2.Text = cant.Codigo_Producto.ToString();
                textBox3.Text = cant.Precio_Producto.ToString();
                textBox4.Text = cant.Total.ToString();
            }
        }

    }

}