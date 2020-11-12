using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public int Negocio { get; private set; }
        public int Codigo { get; private set; }

        public Empresa ObtenerEmpresa(string NombreEmpresa)
        {
            if (NombreEmpresa == "Bimbo")
            {
                return new Empresa() { Nombre_Empresa  = "Bimbo", Ubicacion = "Cd. de Mexico", Nombre_Dueño = "Javier Alvarado", Nombre_Gerente = "Luis de la Hoya", Numero_Empleados = 120, Posicion_Social = "Medio"};
            }
            else if (NombreEmpresa == "CocaCola")
            {
                return new Empresa() { Nombre_Empresa = "CocaCola", Ubicacion = "Durango", Nombre_Dueño = "Ema Valtierra", Nombre_Gerente = "Luisa Vazquez", Numero_Empleados = 150, Posicion_Social = "Alto" };
            }
            else if (NombreEmpresa == "SONY")
            {
                return new Empresa() { Nombre_Empresa = "SONY", Ubicacion = "Estados Unidos", Nombre_Dueño = "Gerardo Ortiz", Nombre_Gerente = "Magdalena Reyes", Numero_Empleados = 170, Posicion_Social = "Medio" };
            }
            else if (NombreEmpresa == "DELL")
            {
                return new Empresa() { Nombre_Empresa = "DELL", Ubicacion = "Estados Unidos", Nombre_Dueño = "Jennifer Quiroz", Nombre_Gerente = "Saul Torres", Numero_Empleados = 160, Posicion_Social = "Alto" };
            }
            else
            {
                return new Empresa() { Error = "Empresa no encontrada" };
            }
        }
        public Empleado ObtenerEmpleado(int NoEmpleado)
        {
            if (NoEmpleado == 240611)
            {
                return new Empleado() { No_Empleado = 240611, Nombre = "Nicolas", Apellido_Paterno = "Fernandez", Apellido_Materno = "Gurrola", Empresa_Perteneciente = "Bimbo" ,Departamento = "Produccion" };
            }
            else if (NoEmpleado == 240612)
            {
                return new Empleado() { No_Empleado = 240612, Nombre = "Sandra", Apellido_Paterno = "Maldonado", Apellido_Materno = "Ceniceros", Empresa_Perteneciente = "CocaCola",Departamento = "Recursos Humanos" };
            }
            else if (NoEmpleado == 240613)
            {
                return new Empleado() { No_Empleado = 240613, Nombre = "Jaqueline", Apellido_Paterno = "Fernandez", Apellido_Materno = "Maldonado", Empresa_Perteneciente = "SONY", Departamento = "Diseño" };
            }
            else if (NoEmpleado == 240614)
            {
                return new Empleado() { No_Empleado = 240614, Nombre = "Octavio", Apellido_Paterno = "Castillo", Apellido_Materno = "Salazar", Empresa_Perteneciente = "DELL",Departamento = "Diseño de software" };
            }
            else
            {
                return new Empleado() { Error = "Empleado no encontrado" };
            }
        }

        public Producto ObtenerProducto (int CodigoProducto)
        {
            if (CodigoProducto == 8934)
            {
                return new Producto() { Codigo_Producto = 8934, Nombre = "Mantecadas", Cantidad = 25, Precio = 13, Empresa_Proviene = "Bimbo", Existencia_Almacen = "Si" };
            }
            else if (CodigoProducto == 8935)
            {
                return new Producto() { Codigo_Producto = 8935, Nombre = "Jugo Valle", Cantidad = 9, Precio = 15, Empresa_Proviene = "CocaCola", Existencia_Almacen = "Si" };
            }
            else if (CodigoProducto == 8936)
            {
                return new Producto() { Codigo_Producto = 8936, Nombre = "Celualr SONY", Cantidad = 100, Precio = 3500, Empresa_Proviene = "SONY", Existencia_Almacen = "Si" };
            }
            else if (CodigoProducto == 8937)
            {
                return new Producto() { Codigo_Producto = 8937, Nombre = "Computadora DELL", Cantidad = 125, Precio = 8999, Empresa_Proviene = "DELL", Existencia_Almacen = "Si" };
            }
            else
            {
                return new Producto() { Error = "Producto no encontrado" };
            }

        }

        public Descuentos ObtenerDescuentoss(string NombreProducto, int Descuento)
        {
            if (NombreProducto == "Mantecadas")
            {
                decimal des;
                decimal precio;
                precio = 13;
                des = precio - ((precio * Descuento) / 100);
                return new  Descuentos(){
                    Nombre_Producto = "Mantecadas",
                    Codigo_Producto = 8934,
                    Precio_Producto = 13,
                    Descuento = des};

            }
            else if (NombreProducto == "Jugo Valle")
            {
                decimal des;
                decimal precio;
                precio = 15;
                des = precio - ((precio * Descuento) / 100);
                return new Descuentos() {
                    Nombre_Producto = "Jugo Valle",
                    Codigo_Producto = 8935,
                    Precio_Producto = 15,
                    Descuento = des };
            }
            else if (NombreProducto == "Celular SONY")
            {
                decimal des;
                decimal precio;
                precio = 3500;
                des = precio - ((precio * Descuento) / 100);
                return new Descuentos() {
                    Nombre_Producto = "Celular SONY",
                    Codigo_Producto = 8936,
                    Precio_Producto = 3500,
                    Descuento = des };
            }
            else if (NombreProducto == "Computadroa DELL")
            {
                decimal des;
                decimal precio;
                precio = 8999;
                des = precio - ((precio * Descuento) / 100);
                return new Descuentos() {
                    Nombre_Producto = "Computadora DELL",
                    Codigo_Producto = 8937,
                    Precio_Producto = 8999,
                    Descuento = des };
            }
            else
            {
                return new Descuentos() { Error = "Descuento del Producto no encontrado" };
            }
        }

        public Cantidaad ObtenerCantidad (string NombreProducto, int Cantidad)
        {
            if (NombreProducto == "Mantecadas")
            {
                decimal tot;
                decimal precio;
                precio = 13;
                tot = (precio * Cantidad);
                return new Cantidaad()
                {
                    Nombre_Producto = "Mantecadas",
                    Codigo_Producto = 8934,
                    Precio_Producto = 13,
                    Total = tot
                };

            }
            else if (NombreProducto == "Jugo Valle")
            {
                decimal tot;
                decimal precio;
                precio = 15;
                tot = (precio * Cantidad);
                return new Cantidaad()
                {
                    Nombre_Producto = "Jugo Valle",
                    Codigo_Producto = 8935,
                    Precio_Producto = 15,
                    Total = tot
                };
            }
            else if (NombreProducto == "Celular SONY")
            {
                decimal tot;
                decimal precio;
                precio = 3500;
                tot = (precio * Cantidad);
                return new Cantidaad()
                {
                    Nombre_Producto = "Celular SONY",
                    Codigo_Producto = 8936,
                    Precio_Producto = 3500,
                    Total = tot
                };
            }
            else if (NombreProducto == "Computadora DELL")
            {
                decimal tot;
                decimal precio;
                precio = 8999;
                tot = (precio * Cantidad);
                return new Cantidaad()
                {
                    Nombre_Producto = "Computadora DELL",
                    Codigo_Producto = 8937,
                    Precio_Producto = 8999,
                    Total = tot
                };
            }
            else
            {
                return new Cantidaad() { Error = "Cantidad del Producto no encontrado" };
            }
        }
    }

}

   

    

