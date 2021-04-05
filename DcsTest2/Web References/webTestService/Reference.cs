﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace DcsTest2.webTestService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TestServiceSoap", Namespace="http://tempuri.org/")]
    public partial class TestService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetUsernameAndPasswordOperationCompleted;
        
        private System.Threading.SendOrPostCallback SuppliersGainOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TestService() {
            this.Url = global::DcsTest2.Properties.Settings.Default.DcsTest2_webTestService_TestService;
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
        public event GetUsernameAndPasswordCompletedEventHandler GetUsernameAndPasswordCompleted;
        
        /// <remarks/>
        public event SuppliersGainCompletedEventHandler SuppliersGainCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUsernameAndPassword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetUsernameAndPassword() {
            object[] results = this.Invoke("GetUsernameAndPassword", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetUsernameAndPasswordAsync() {
            this.GetUsernameAndPasswordAsync(null);
        }
        
        /// <remarks/>
        public void GetUsernameAndPasswordAsync(object userState) {
            if ((this.GetUsernameAndPasswordOperationCompleted == null)) {
                this.GetUsernameAndPasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUsernameAndPasswordOperationCompleted);
            }
            this.InvokeAsync("GetUsernameAndPassword", new object[0], this.GetUsernameAndPasswordOperationCompleted, userState);
        }
        
        private void OnGetUsernameAndPasswordOperationCompleted(object arg) {
            if ((this.GetUsernameAndPasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUsernameAndPasswordCompleted(this, new GetUsernameAndPasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SuppliersGain", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SupplierGain[] SuppliersGain(string iUserName, string iPassword, Supplier[] Suppliers) {
            System.Diagnostics.Debug.WriteLine("aviad1: " + Suppliers);
            System.Diagnostics.Debug.WriteLine("user: " + iUserName);
            System.Diagnostics.Debug.WriteLine("pass: " + iPassword);
            object[] results = this.Invoke("SuppliersGain", new object[] {
                        iUserName,
                        iPassword,
                        Suppliers});
            System.Diagnostics.Debug.WriteLine("aviad: " + results);
            System.Diagnostics.Debug.WriteLine("aviad: " + results[0]);
            System.Diagnostics.Debug.WriteLine("aviad3: " + (SupplierGain[])(results[0]));
            return ((SupplierGain[])(results[0]));
        }
        
        /// <remarks/>
        public void SuppliersGainAsync(string iUserName, string iPassword, Supplier[] Suppliers) {
            this.SuppliersGainAsync(iUserName, iPassword, Suppliers, null);
        }
        
        /// <remarks/>
        public void SuppliersGainAsync(string iUserName, string iPassword, Supplier[] Suppliers, object userState) {
            if ((this.SuppliersGainOperationCompleted == null)) {
                this.SuppliersGainOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSuppliersGainOperationCompleted);
            }
            this.InvokeAsync("SuppliersGain", new object[] {
                        iUserName,
                        iPassword,
                        Suppliers}, this.SuppliersGainOperationCompleted, userState);
        }
        
        private void OnSuppliersGainOperationCompleted(object arg) {
            if ((this.SuppliersGainCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SuppliersGainCompleted(this, new SuppliersGainCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Supplier {
        
        private string idField;
        
        private string nameField;
        
        private decimal bruttoField;
        
        private decimal nettoField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public decimal Brutto {
            get {
                return this.bruttoField;
            }
            set {
                this.bruttoField = value;
            }
        }
        
        /// <remarks/>
        public decimal Netto {
            get {
                return this.nettoField;
            }
            set {
                this.nettoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SupplierGain {
        
        private string nameField;
        
        private decimal totalGainField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public decimal TotalGain {
            get {
                return this.totalGainField;
            }
            set {
                this.totalGainField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetUsernameAndPasswordCompletedEventHandler(object sender, GetUsernameAndPasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUsernameAndPasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUsernameAndPasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SuppliersGainCompletedEventHandler(object sender, SuppliersGainCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SuppliersGainCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SuppliersGainCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SupplierGain[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SupplierGain[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591