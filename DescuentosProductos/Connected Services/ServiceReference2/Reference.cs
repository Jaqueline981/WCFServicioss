﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DescuentosProductos.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="REST", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DescuentosProductos.ServiceReference2.Empresa))]
    public partial class REST : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Empresa", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    public partial class Empresa : DescuentosProductos.ServiceReference2.REST {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_DueñoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_EmpresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_GerenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Numero_EmpleadosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Posicion_SocialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UbicacionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Dueño {
            get {
                return this.Nombre_DueñoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_DueñoField, value) != true)) {
                    this.Nombre_DueñoField = value;
                    this.RaisePropertyChanged("Nombre_Dueño");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Empresa {
            get {
                return this.Nombre_EmpresaField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_EmpresaField, value) != true)) {
                    this.Nombre_EmpresaField = value;
                    this.RaisePropertyChanged("Nombre_Empresa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Gerente {
            get {
                return this.Nombre_GerenteField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_GerenteField, value) != true)) {
                    this.Nombre_GerenteField = value;
                    this.RaisePropertyChanged("Nombre_Gerente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numero_Empleados {
            get {
                return this.Numero_EmpleadosField;
            }
            set {
                if ((this.Numero_EmpleadosField.Equals(value) != true)) {
                    this.Numero_EmpleadosField = value;
                    this.RaisePropertyChanged("Numero_Empleados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posicion_Social {
            get {
                return this.Posicion_SocialField;
            }
            set {
                if ((object.ReferenceEquals(this.Posicion_SocialField, value) != true)) {
                    this.Posicion_SocialField = value;
                    this.RaisePropertyChanged("Posicion_Social");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ubicacion {
            get {
                return this.UbicacionField;
            }
            set {
                if ((object.ReferenceEquals(this.UbicacionField, value) != true)) {
                    this.UbicacionField = value;
                    this.RaisePropertyChanged("Ubicacion");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Resp", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DescuentosProductos.ServiceReference2.Empleado))]
    public partial class Resp : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Empleado", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    public partial class Empleado : DescuentosProductos.ServiceReference2.Resp {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Apellido_MaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Apellido_PaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Empresa_PertenecienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int No_EmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido_Materno {
            get {
                return this.Apellido_MaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.Apellido_MaternoField, value) != true)) {
                    this.Apellido_MaternoField = value;
                    this.RaisePropertyChanged("Apellido_Materno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido_Paterno {
            get {
                return this.Apellido_PaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.Apellido_PaternoField, value) != true)) {
                    this.Apellido_PaternoField = value;
                    this.RaisePropertyChanged("Apellido_Paterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departamento {
            get {
                return this.DepartamentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartamentoField, value) != true)) {
                    this.DepartamentoField = value;
                    this.RaisePropertyChanged("Departamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Empresa_Perteneciente {
            get {
                return this.Empresa_PertenecienteField;
            }
            set {
                if ((object.ReferenceEquals(this.Empresa_PertenecienteField, value) != true)) {
                    this.Empresa_PertenecienteField = value;
                    this.RaisePropertyChanged("Empresa_Perteneciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int No_Empleado {
            get {
                return this.No_EmpleadoField;
            }
            set {
                if ((this.No_EmpleadoField.Equals(value) != true)) {
                    this.No_EmpleadoField = value;
                    this.RaisePropertyChanged("No_Empleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respuesta", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DescuentosProductos.ServiceReference2.Producto))]
    public partial class Respuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    public partial class Producto : DescuentosProductos.ServiceReference2.Respuesta {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Codigo_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Empresa_ProvieneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Existencia_AlmacenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrecioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo_Producto {
            get {
                return this.Codigo_ProductoField;
            }
            set {
                if ((this.Codigo_ProductoField.Equals(value) != true)) {
                    this.Codigo_ProductoField = value;
                    this.RaisePropertyChanged("Codigo_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Empresa_Proviene {
            get {
                return this.Empresa_ProvieneField;
            }
            set {
                if ((object.ReferenceEquals(this.Empresa_ProvieneField, value) != true)) {
                    this.Empresa_ProvieneField = value;
                    this.RaisePropertyChanged("Empresa_Proviene");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Existencia_Almacen {
            get {
                return this.Existencia_AlmacenField;
            }
            set {
                if ((object.ReferenceEquals(this.Existencia_AlmacenField, value) != true)) {
                    this.Existencia_AlmacenField = value;
                    this.RaisePropertyChanged("Existencia_Almacen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respu", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DescuentosProductos.ServiceReference2.Descuentos))]
    public partial class Respu : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Descuentos", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    public partial class Descuentos : DescuentosProductos.ServiceReference2.Respu {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Codigo_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DescuentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Precio_ProductoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo_Producto {
            get {
                return this.Codigo_ProductoField;
            }
            set {
                if ((this.Codigo_ProductoField.Equals(value) != true)) {
                    this.Codigo_ProductoField = value;
                    this.RaisePropertyChanged("Codigo_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Descuento {
            get {
                return this.DescuentoField;
            }
            set {
                if ((this.DescuentoField.Equals(value) != true)) {
                    this.DescuentoField = value;
                    this.RaisePropertyChanged("Descuento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Producto {
            get {
                return this.Nombre_ProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_ProductoField, value) != true)) {
                    this.Nombre_ProductoField = value;
                    this.RaisePropertyChanged("Nombre_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Precio_Producto {
            get {
                return this.Precio_ProductoField;
            }
            set {
                if ((this.Precio_ProductoField.Equals(value) != true)) {
                    this.Precio_ProductoField = value;
                    this.RaisePropertyChanged("Precio_Producto");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respues", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DescuentosProductos.ServiceReference2.Cantidaad))]
    public partial class Respues : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cantidaad", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    public partial class Cantidaad : DescuentosProductos.ServiceReference2.Respues {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Codigo_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Precio_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo_Producto {
            get {
                return this.Codigo_ProductoField;
            }
            set {
                if ((this.Codigo_ProductoField.Equals(value) != true)) {
                    this.Codigo_ProductoField = value;
                    this.RaisePropertyChanged("Codigo_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Producto {
            get {
                return this.Nombre_ProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_ProductoField, value) != true)) {
                    this.Nombre_ProductoField = value;
                    this.RaisePropertyChanged("Nombre_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Precio_Producto {
            get {
                return this.Precio_ProductoField;
            }
            set {
                if ((this.Precio_ProductoField.Equals(value) != true)) {
                    this.Precio_ProductoField = value;
                    this.RaisePropertyChanged("Precio_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerEmpresa", ReplyAction="http://tempuri.org/IService1/ObtenerEmpresaResponse")]
        DescuentosProductos.ServiceReference2.Empresa ObtenerEmpresa(string NombreEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerEmpleado", ReplyAction="http://tempuri.org/IService1/ObtenerEmpleadoResponse")]
        DescuentosProductos.ServiceReference2.Empleado ObtenerEmpleado(int NoEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerProducto", ReplyAction="http://tempuri.org/IService1/ObtenerProductoResponse")]
        DescuentosProductos.ServiceReference2.Producto ObtenerProducto(int CodigoProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerDescuentoss", ReplyAction="http://tempuri.org/IService1/ObtenerDescuentossResponse")]
        DescuentosProductos.ServiceReference2.Descuentos ObtenerDescuentoss(string NombreProducto, int Descuento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerCantidad", ReplyAction="http://tempuri.org/IService1/ObtenerCantidadResponse")]
        DescuentosProductos.ServiceReference2.Cantidaad ObtenerCantidad(string NombreProducto, int Cantidad);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DescuentosProductos.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DescuentosProductos.ServiceReference2.IService1>, DescuentosProductos.ServiceReference2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DescuentosProductos.ServiceReference2.Empresa ObtenerEmpresa(string NombreEmpresa) {
            return base.Channel.ObtenerEmpresa(NombreEmpresa);
        }
        
        public DescuentosProductos.ServiceReference2.Empleado ObtenerEmpleado(int NoEmpleado) {
            return base.Channel.ObtenerEmpleado(NoEmpleado);
        }
        
        public DescuentosProductos.ServiceReference2.Producto ObtenerProducto(int CodigoProducto) {
            return base.Channel.ObtenerProducto(CodigoProducto);
        }
        
        public DescuentosProductos.ServiceReference2.Descuentos ObtenerDescuentoss(string NombreProducto, int Descuento) {
            return base.Channel.ObtenerDescuentoss(NombreProducto, Descuento);
        }
        
        public DescuentosProductos.ServiceReference2.Cantidaad ObtenerCantidad(string NombreProducto, int Cantidad) {
            return base.Channel.ObtenerCantidad(NombreProducto, Cantidad);
        }
    }
}
