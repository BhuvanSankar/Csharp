﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newprac2.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.prac2form1service2Soap")]
    public interface prac2form1service2Soap {
        
        // CODEGEN: Generating message contract since element name n from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/zodfinder", ReplyAction="*")]
        newprac2.ServiceReference2.zodfinderResponse zodfinder(newprac2.ServiceReference2.zodfinderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/zodfinder", ReplyAction="*")]
        System.Threading.Tasks.Task<newprac2.ServiceReference2.zodfinderResponse> zodfinderAsync(newprac2.ServiceReference2.zodfinderRequest request);
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        newprac2.ServiceReference2.HelloWorldResponse HelloWorld(newprac2.ServiceReference2.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<newprac2.ServiceReference2.HelloWorldResponse> HelloWorldAsync(newprac2.ServiceReference2.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class zodfinderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="zodfinder", Namespace="http://tempuri.org/", Order=0)]
        public newprac2.ServiceReference2.zodfinderRequestBody Body;
        
        public zodfinderRequest() {
        }
        
        public zodfinderRequest(newprac2.ServiceReference2.zodfinderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class zodfinderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string n;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string m;
        
        public zodfinderRequestBody() {
        }
        
        public zodfinderRequestBody(string n, string m) {
            this.n = n;
            this.m = m;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class zodfinderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="zodfinderResponse", Namespace="http://tempuri.org/", Order=0)]
        public newprac2.ServiceReference2.zodfinderResponseBody Body;
        
        public zodfinderResponse() {
        }
        
        public zodfinderResponse(newprac2.ServiceReference2.zodfinderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class zodfinderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string zodfinderResult;
        
        public zodfinderResponseBody() {
        }
        
        public zodfinderResponseBody(string zodfinderResult) {
            this.zodfinderResult = zodfinderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public newprac2.ServiceReference2.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(newprac2.ServiceReference2.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public newprac2.ServiceReference2.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(newprac2.ServiceReference2.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface prac2form1service2SoapChannel : newprac2.ServiceReference2.prac2form1service2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class prac2form1service2SoapClient : System.ServiceModel.ClientBase<newprac2.ServiceReference2.prac2form1service2Soap>, newprac2.ServiceReference2.prac2form1service2Soap {
        
        public prac2form1service2SoapClient() {
        }
        
        public prac2form1service2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public prac2form1service2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public prac2form1service2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public prac2form1service2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        newprac2.ServiceReference2.zodfinderResponse newprac2.ServiceReference2.prac2form1service2Soap.zodfinder(newprac2.ServiceReference2.zodfinderRequest request) {
            return base.Channel.zodfinder(request);
        }
        
        public string zodfinder(string n, string m) {
            newprac2.ServiceReference2.zodfinderRequest inValue = new newprac2.ServiceReference2.zodfinderRequest();
            inValue.Body = new newprac2.ServiceReference2.zodfinderRequestBody();
            inValue.Body.n = n;
            inValue.Body.m = m;
            newprac2.ServiceReference2.zodfinderResponse retVal = ((newprac2.ServiceReference2.prac2form1service2Soap)(this)).zodfinder(inValue);
            return retVal.Body.zodfinderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<newprac2.ServiceReference2.zodfinderResponse> newprac2.ServiceReference2.prac2form1service2Soap.zodfinderAsync(newprac2.ServiceReference2.zodfinderRequest request) {
            return base.Channel.zodfinderAsync(request);
        }
        
        public System.Threading.Tasks.Task<newprac2.ServiceReference2.zodfinderResponse> zodfinderAsync(string n, string m) {
            newprac2.ServiceReference2.zodfinderRequest inValue = new newprac2.ServiceReference2.zodfinderRequest();
            inValue.Body = new newprac2.ServiceReference2.zodfinderRequestBody();
            inValue.Body.n = n;
            inValue.Body.m = m;
            return ((newprac2.ServiceReference2.prac2form1service2Soap)(this)).zodfinderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        newprac2.ServiceReference2.HelloWorldResponse newprac2.ServiceReference2.prac2form1service2Soap.HelloWorld(newprac2.ServiceReference2.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            newprac2.ServiceReference2.HelloWorldRequest inValue = new newprac2.ServiceReference2.HelloWorldRequest();
            inValue.Body = new newprac2.ServiceReference2.HelloWorldRequestBody();
            newprac2.ServiceReference2.HelloWorldResponse retVal = ((newprac2.ServiceReference2.prac2form1service2Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<newprac2.ServiceReference2.HelloWorldResponse> newprac2.ServiceReference2.prac2form1service2Soap.HelloWorldAsync(newprac2.ServiceReference2.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<newprac2.ServiceReference2.HelloWorldResponse> HelloWorldAsync() {
            newprac2.ServiceReference2.HelloWorldRequest inValue = new newprac2.ServiceReference2.HelloWorldRequest();
            inValue.Body = new newprac2.ServiceReference2.HelloWorldRequestBody();
            return ((newprac2.ServiceReference2.prac2form1service2Soap)(this)).HelloWorldAsync(inValue);
        }
    }
}