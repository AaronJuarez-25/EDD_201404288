﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteEDD.ServicioWebCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioWebCliente.LoginSoap")]
    public interface LoginSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/log", ReplyAction="*")]
        ClienteEDD.ServicioWebCliente.logResponse log(ClienteEDD.ServicioWebCliente.logRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/log", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteEDD.ServicioWebCliente.logResponse> logAsync(ClienteEDD.ServicioWebCliente.logRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class logRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="log", Namespace="http://tempuri.org/", Order=0)]
        public ClienteEDD.ServicioWebCliente.logRequestBody Body;
        
        public logRequest() {
        }
        
        public logRequest(ClienteEDD.ServicioWebCliente.logRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class logRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pw;
        
        public logRequestBody() {
        }
        
        public logRequestBody(string nombre, string pw) {
            this.nombre = nombre;
            this.pw = pw;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class logResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="logResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteEDD.ServicioWebCliente.logResponseBody Body;
        
        public logResponse() {
        }
        
        public logResponse(ClienteEDD.ServicioWebCliente.logResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class logResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool logResult;
        
        public logResponseBody() {
        }
        
        public logResponseBody(bool logResult) {
            this.logResult = logResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LoginSoapChannel : ClienteEDD.ServicioWebCliente.LoginSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginSoapClient : System.ServiceModel.ClientBase<ClienteEDD.ServicioWebCliente.LoginSoap>, ClienteEDD.ServicioWebCliente.LoginSoap {
        
        public LoginSoapClient() {
        }
        
        public LoginSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteEDD.ServicioWebCliente.logResponse ClienteEDD.ServicioWebCliente.LoginSoap.log(ClienteEDD.ServicioWebCliente.logRequest request) {
            return base.Channel.log(request);
        }
        
        public bool log(string nombre, string pw) {
            ClienteEDD.ServicioWebCliente.logRequest inValue = new ClienteEDD.ServicioWebCliente.logRequest();
            inValue.Body = new ClienteEDD.ServicioWebCliente.logRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.pw = pw;
            ClienteEDD.ServicioWebCliente.logResponse retVal = ((ClienteEDD.ServicioWebCliente.LoginSoap)(this)).log(inValue);
            return retVal.Body.logResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteEDD.ServicioWebCliente.logResponse> ClienteEDD.ServicioWebCliente.LoginSoap.logAsync(ClienteEDD.ServicioWebCliente.logRequest request) {
            return base.Channel.logAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteEDD.ServicioWebCliente.logResponse> logAsync(string nombre, string pw) {
            ClienteEDD.ServicioWebCliente.logRequest inValue = new ClienteEDD.ServicioWebCliente.logRequest();
            inValue.Body = new ClienteEDD.ServicioWebCliente.logRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.pw = pw;
            return ((ClienteEDD.ServicioWebCliente.LoginSoap)(this)).logAsync(inValue);
        }
    }
}
