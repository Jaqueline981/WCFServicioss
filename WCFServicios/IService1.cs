using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        //string GetData(int value);
        Empresa ObtenerEmpresa(string NombreEmpresa);

        [OperationContract]
        //string GetData(int value);
        Empleado ObtenerEmpleado(int NoEmpleado);

        [OperationContract]
        //string GetData(int value);
        Producto ObtenerProducto(int CodigoProducto);

        [OperationContract]
        //string GetData(int value);
        Descuentos ObtenerDescuentoss(string NombreProducto, int Descuento);

        [OperationContract]
        //string GetData(int value);
        Cantidaad ObtenerCantidad(string NombreProducto, int Cantidad);

        // TODO: agregue aquí sus operaciones de servicio
    }

    

    public class Empresa: REST
    {
        [DataMember]
        public string Nombre_Empresa { get; set; }

        [DataMember]
        public string Ubicacion { get; set; }

        [DataMember]
        public string Nombre_Dueño { get; set; }

        [DataMember]
        public string Nombre_Gerente { get; set; }

        [DataMember]
        public int Numero_Empleados { get; set; }

        [DataMember]
        public string Posicion_Social { get; set; }
    }

    public class REST
    {
        public string Error { get; set; }
    }

    public class Empleado: Resp
    {
        [DataMember]
        public int No_Empleado { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Apellido_Paterno { get; set; }

        [DataMember]
        public string Apellido_Materno { get; set; }

        [DataMember]
        public string Empresa_Perteneciente { get; set; }

        [DataMember]
        public string Departamento { get; set; }
    }

    public class Resp
    {
        public string Error { get; set; }
    }

    public class Producto : Respuesta
    {
        [DataMember]
        public int Codigo_Producto { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public int Cantidad { get; set; }

        [DataMember]
        public int Precio { get; set; }

        [DataMember]
        public string Empresa_Proviene { get; set; }

        [DataMember]
        public string Existencia_Almacen { get; set; }
    }

    public class Respuesta
    {
        public string Error { get; set; }
    }

    public class Descuentos: Respu
    {
        [DataMember]
        public string Nombre_Producto { get; set; }

        [DataMember]
        public int Codigo_Producto { get; set; }

        [DataMember]
        public int Precio_Producto { get; set; }

        [DataMember]
        public decimal Descuento { get; set; }
    }

    public class Respu
    {
        public string Error { get; set; }
    }

    public class Cantidaad: Respues
    {
        [DataMember]
        public string Nombre_Producto { get; set; }

        [DataMember]
        public int Codigo_Producto { get; set; }

        [DataMember]
        public int Precio_Producto { get; set; }

        [DataMember]
        public decimal Total { get; set; }
    }

    public class Respues
    {
        public string Error { get; set; }
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
