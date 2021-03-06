//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="HyggeServiceSoap", Namespace="http://tempuri.org/")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(object[][]))]
public partial class HyggeService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
    
    private System.Threading.SendOrPostCallback ViewAllOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetTableAsListOperationCompleted;
    
    /// <remarks/>
    public HyggeService() {
        this.Url = "http://localhost/Assignment3Client/HyggeService.asmx";
    }
    
    /// <remarks/>
    public event HelloWorldCompletedEventHandler HelloWorldCompleted;
    
    /// <remarks/>
    public event ViewAllCompletedEventHandler ViewAllCompleted;
    
    /// <remarks/>
    public event GetTableAsListCompletedEventHandler GetTableAsListCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string HelloWorld() {
        object[] results = this.Invoke("HelloWorld", new object[0]);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("HelloWorld", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string EndHelloWorld(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void HelloWorldAsync() {
        this.HelloWorldAsync(null);
    }
    
    /// <remarks/>
    public void HelloWorldAsync(object userState) {
        if ((this.HelloWorldOperationCompleted == null)) {
            this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
        }
        this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
    }
    
    private void OnHelloWorldOperationCompleted(object arg) {
        if ((this.HelloWorldCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ViewAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataSet ViewAll(string table) {
        object[] results = this.Invoke("ViewAll", new object[] {
                    table});
        return ((System.Data.DataSet)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginViewAll(string table, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ViewAll", new object[] {
                    table}, callback, asyncState);
    }
    
    /// <remarks/>
    public System.Data.DataSet EndViewAll(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataSet)(results[0]));
    }
    
    /// <remarks/>
    public void ViewAllAsync(string table) {
        this.ViewAllAsync(table, null);
    }
    
    /// <remarks/>
    public void ViewAllAsync(string table, object userState) {
        if ((this.ViewAllOperationCompleted == null)) {
            this.ViewAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnViewAllOperationCompleted);
        }
        this.InvokeAsync("ViewAll", new object[] {
                    table}, this.ViewAllOperationCompleted, userState);
    }
    
    private void OnViewAllOperationCompleted(object arg) {
        if ((this.ViewAllCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ViewAllCompleted(this, new ViewAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTableAsList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfAnyType")]
    [return: System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
    public object[][] GetTableAsList(string tableName) {
        object[] results = this.Invoke("GetTableAsList", new object[] {
                    tableName});
        return ((object[][])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetTableAsList(string tableName, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetTableAsList", new object[] {
                    tableName}, callback, asyncState);
    }
    
    /// <remarks/>
    public object[][] EndGetTableAsList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((object[][])(results[0]));
    }
    
    /// <remarks/>
    public void GetTableAsListAsync(string tableName) {
        this.GetTableAsListAsync(tableName, null);
    }
    
    /// <remarks/>
    public void GetTableAsListAsync(string tableName, object userState) {
        if ((this.GetTableAsListOperationCompleted == null)) {
            this.GetTableAsListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTableAsListOperationCompleted);
        }
        this.InvokeAsync("GetTableAsList", new object[] {
                    tableName}, this.GetTableAsListOperationCompleted, userState);
    }
    
    private void OnGetTableAsListOperationCompleted(object arg) {
        if ((this.GetTableAsListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetTableAsListCompleted(this, new GetTableAsListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void ViewAllCompletedEventHandler(object sender, ViewAllCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ViewAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ViewAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void GetTableAsListCompletedEventHandler(object sender, GetTableAsListCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetTableAsListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetTableAsListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public object[][] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((object[][])(this.results[0]));
        }
    }
}
