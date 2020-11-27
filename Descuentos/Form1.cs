using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Descuentos
{
    public partial class Form1 : Form
    {
        ServiceDescuento1.Service1Client cliente = new ServiceDescuento1.Service1Client();
        public Form1()
        {
            InitializeComponent();
            ServiceDescuento1.Service1Client cliente = new ServiceDescuento1.Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nom = textBox5.Text;
            var des = Convert.ToInt32(textBox6.Text);

            using(ServiceDescuento1.Service1Client cliente = new ServiceDescuento1.Service1Client())
            {
                var descu = cliente.ObtenerDescuentoss(nom, des);
                var nombre = descu.Nombre_Producto;
                var codigo = descu.Codigo_Producto;
                var precio = descu.Precio;
                var descuento = descu.Descuento;

                textBox1.Text = descu.Nombre_Producto.ToString();
                textBox2.Text = descu.Codigo_Producto.ToString();
                textBox3.Text = descu.Precio.ToString();
                textBox4.Text = descu.Descuento.ToString();
            }

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
    }
}
