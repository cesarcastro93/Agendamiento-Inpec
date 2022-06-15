﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace InpecTurnos.WSAgendamiento {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSAgendaSoap", Namespace="http://tempuri.org/")]
    public partial class WSAgenda : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ObtenerOficinasOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerServiciosOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerHorariosAgendaOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertaAgendaOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidaCedulaOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerDatosTurnosOperationCompleted;
        
        private System.Threading.SendOrPostCallback BorraAgendaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSAgenda() {
            this.Url = global::InpecTurnos.Properties.Settings.Default.InpecTurnos_WSAgendamiento_WSAgenda;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ObtenerOficinasCompletedEventHandler ObtenerOficinasCompleted;
        
        /// <remarks/>
        public event ObtenerServiciosCompletedEventHandler ObtenerServiciosCompleted;
        
        /// <remarks/>
        public event ObtenerHorariosAgendaCompletedEventHandler ObtenerHorariosAgendaCompleted;
        
        /// <remarks/>
        public event InsertaAgendaCompletedEventHandler InsertaAgendaCompleted;
        
        /// <remarks/>
        public event ValidaCedulaCompletedEventHandler ValidaCedulaCompleted;
        
        /// <remarks/>
        public event ObtenerDatosTurnosCompletedEventHandler ObtenerDatosTurnosCompleted;
        
        /// <remarks/>
        public event BorraAgendaCompletedEventHandler BorraAgendaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerOficinas", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ObtenerOficinas() {
            object[] results = this.Invoke("ObtenerOficinas", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerOficinasAsync() {
            this.ObtenerOficinasAsync(null);
        }
        
        /// <remarks/>
        public void ObtenerOficinasAsync(object userState) {
            if ((this.ObtenerOficinasOperationCompleted == null)) {
                this.ObtenerOficinasOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerOficinasOperationCompleted);
            }
            this.InvokeAsync("ObtenerOficinas", new object[0], this.ObtenerOficinasOperationCompleted, userState);
        }
        
        private void OnObtenerOficinasOperationCompleted(object arg) {
            if ((this.ObtenerOficinasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerOficinasCompleted(this, new ObtenerOficinasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerServicios", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ObtenerServicios() {
            object[] results = this.Invoke("ObtenerServicios", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerServiciosAsync() {
            this.ObtenerServiciosAsync(null);
        }
        
        /// <remarks/>
        public void ObtenerServiciosAsync(object userState) {
            if ((this.ObtenerServiciosOperationCompleted == null)) {
                this.ObtenerServiciosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerServiciosOperationCompleted);
            }
            this.InvokeAsync("ObtenerServicios", new object[0], this.ObtenerServiciosOperationCompleted, userState);
        }
        
        private void OnObtenerServiciosOperationCompleted(object arg) {
            if ((this.ObtenerServiciosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerServiciosCompleted(this, new ObtenerServiciosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerHorariosAgenda", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ObtenerHorariosAgenda(string Sede, string fecha) {
            object[] results = this.Invoke("ObtenerHorariosAgenda", new object[] {
                        Sede,
                        fecha});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerHorariosAgendaAsync(string Sede, string fecha) {
            this.ObtenerHorariosAgendaAsync(Sede, fecha, null);
        }
        
        /// <remarks/>
        public void ObtenerHorariosAgendaAsync(string Sede, string fecha, object userState) {
            if ((this.ObtenerHorariosAgendaOperationCompleted == null)) {
                this.ObtenerHorariosAgendaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerHorariosAgendaOperationCompleted);
            }
            this.InvokeAsync("ObtenerHorariosAgenda", new object[] {
                        Sede,
                        fecha}, this.ObtenerHorariosAgendaOperationCompleted, userState);
        }
        
        private void OnObtenerHorariosAgendaOperationCompleted(object arg) {
            if ((this.ObtenerHorariosAgendaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerHorariosAgendaCompleted(this, new ObtenerHorariosAgendaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertaAgenda", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool InsertaAgenda(string Sede, string TipoServicio, string fecha, string Horario, string cedula) {
            object[] results = this.Invoke("InsertaAgenda", new object[] {
                        Sede,
                        TipoServicio,
                        fecha,
                        Horario,
                        cedula});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void InsertaAgendaAsync(string Sede, string TipoServicio, string fecha, string Horario, string cedula) {
            this.InsertaAgendaAsync(Sede, TipoServicio, fecha, Horario, cedula, null);
        }
        
        /// <remarks/>
        public void InsertaAgendaAsync(string Sede, string TipoServicio, string fecha, string Horario, string cedula, object userState) {
            if ((this.InsertaAgendaOperationCompleted == null)) {
                this.InsertaAgendaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertaAgendaOperationCompleted);
            }
            this.InvokeAsync("InsertaAgenda", new object[] {
                        Sede,
                        TipoServicio,
                        fecha,
                        Horario,
                        cedula}, this.InsertaAgendaOperationCompleted, userState);
        }
        
        private void OnInsertaAgendaOperationCompleted(object arg) {
            if ((this.InsertaAgendaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertaAgendaCompleted(this, new InsertaAgendaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidaCedula", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ValidaCedula(string cedula) {
            object[] results = this.Invoke("ValidaCedula", new object[] {
                        cedula});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ValidaCedulaAsync(string cedula) {
            this.ValidaCedulaAsync(cedula, null);
        }
        
        /// <remarks/>
        public void ValidaCedulaAsync(string cedula, object userState) {
            if ((this.ValidaCedulaOperationCompleted == null)) {
                this.ValidaCedulaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidaCedulaOperationCompleted);
            }
            this.InvokeAsync("ValidaCedula", new object[] {
                        cedula}, this.ValidaCedulaOperationCompleted, userState);
        }
        
        private void OnValidaCedulaOperationCompleted(object arg) {
            if ((this.ValidaCedulaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidaCedulaCompleted(this, new ValidaCedulaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerDatosTurnos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ObtenerDatosTurnos(string cedula) {
            object[] results = this.Invoke("ObtenerDatosTurnos", new object[] {
                        cedula});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerDatosTurnosAsync(string cedula) {
            this.ObtenerDatosTurnosAsync(cedula, null);
        }
        
        /// <remarks/>
        public void ObtenerDatosTurnosAsync(string cedula, object userState) {
            if ((this.ObtenerDatosTurnosOperationCompleted == null)) {
                this.ObtenerDatosTurnosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerDatosTurnosOperationCompleted);
            }
            this.InvokeAsync("ObtenerDatosTurnos", new object[] {
                        cedula}, this.ObtenerDatosTurnosOperationCompleted, userState);
        }
        
        private void OnObtenerDatosTurnosOperationCompleted(object arg) {
            if ((this.ObtenerDatosTurnosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerDatosTurnosCompleted(this, new ObtenerDatosTurnosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BorraAgenda", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int BorraAgenda(string cedula) {
            object[] results = this.Invoke("BorraAgenda", new object[] {
                        cedula});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void BorraAgendaAsync(string cedula) {
            this.BorraAgendaAsync(cedula, null);
        }
        
        /// <remarks/>
        public void BorraAgendaAsync(string cedula, object userState) {
            if ((this.BorraAgendaOperationCompleted == null)) {
                this.BorraAgendaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBorraAgendaOperationCompleted);
            }
            this.InvokeAsync("BorraAgenda", new object[] {
                        cedula}, this.BorraAgendaOperationCompleted, userState);
        }
        
        private void OnBorraAgendaOperationCompleted(object arg) {
            if ((this.BorraAgendaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BorraAgendaCompleted(this, new BorraAgendaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ObtenerOficinasCompletedEventHandler(object sender, ObtenerOficinasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerOficinasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerOficinasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ObtenerServiciosCompletedEventHandler(object sender, ObtenerServiciosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerServiciosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerServiciosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ObtenerHorariosAgendaCompletedEventHandler(object sender, ObtenerHorariosAgendaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerHorariosAgendaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerHorariosAgendaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void InsertaAgendaCompletedEventHandler(object sender, InsertaAgendaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertaAgendaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertaAgendaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ValidaCedulaCompletedEventHandler(object sender, ValidaCedulaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidaCedulaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidaCedulaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ObtenerDatosTurnosCompletedEventHandler(object sender, ObtenerDatosTurnosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerDatosTurnosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerDatosTurnosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BorraAgendaCompletedEventHandler(object sender, BorraAgendaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BorraAgendaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BorraAgendaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591