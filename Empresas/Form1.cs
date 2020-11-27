using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Empresas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceEmpresas.Service1Client cliente = new ServiceEmpresas.Service1Client();

          
        }

        //Boton para acceder con el identificador y mostrar los datos ya guardados
        private void button1_Click(object sender, EventArgs e)
        {
            var empre = textBox7.Text;
            using (ServiceEmpresas.Service1Client cliente = new ServiceEmpresas.Service1Client())
            {
                var nempresa = cliente.ObtenerEmpresa(empre);
                var nombre = nempresa.Nombre_Empresa;
                var ubicacion = nempresa.Ubicacion;
                var nombre_dueño = nempresa.Nombre_Dueño;
                var nombre_gerente = nempresa.Nombre_Gerente;
                var numero_empleados = nempresa.Numero_Empleados;
                var posicion_social = nempresa.Posicion_Social;

                textBox1.Text = nempresa.Nombre_Empresa.ToString();
                textBox2.Text = nempresa.Ubicacion.ToString();
                textBox3.Text = nempresa.Nombre_Dueño.ToString();
                textBox4.Text = nempresa.Nombre_Gerente.ToString();
                textBox5.Text = nempresa.Numero_Empleados.ToString();
                textBox6.Text = nempresa.Posicion_Social.ToString();
            } 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Boton para limpiara los textbox y poder invocar otros datos
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
    }
}
