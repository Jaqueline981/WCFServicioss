using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceEmpleados.Service1Client cliente = new ServiceEmpleados.Service1Client();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int cliem = Convert.ToInt32(textBox7.Text);
            using (ServiceEmpleados.Service1Client cliente = new ServiceEmpleados.Service1Client())
            {
                var nomemple = cliente.ObtenerEmpleado(cliem);
                var no_empleado = nomemple.No_Empleado;
                var nombre = nomemple.Nombre;
                var apellido_p = nomemple.Apellido_Paterno;
                var apellido_m = nomemple.Apellido_Materno;
                var empresa_perteneciente = nomemple.Empresa_Perteneciente;
                var departamento = nomemple.Departamento;

                textBox1.Text = nomemple.No_Empleado.ToString();
                textBox2.Text = nomemple.Nombre.ToString();
                textBox3.Text = nomemple.Apellido_Paterno.ToString();
                textBox4.Text = nomemple.Apellido_Materno.ToString();
                textBox5.Text = nomemple.Empresa_Perteneciente.ToString();
                textBox6.Text = nomemple.Departamento.ToString();

            }
        }
    }
}
