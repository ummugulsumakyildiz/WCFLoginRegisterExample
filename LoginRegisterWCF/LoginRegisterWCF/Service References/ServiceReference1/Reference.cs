﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginRegisterWCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        int register(string usernama, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        System.Threading.Tasks.Task<int> registerAsync(string usernama, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        int login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<int> loginAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : LoginRegisterWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<LoginRegisterWCF.ServiceReference1.IService1>, LoginRegisterWCF.ServiceReference1.IService1 {
        
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
        
        public int register(string usernama, string email, string password) {
            return base.Channel.register(usernama, email, password);
        }
        
        public System.Threading.Tasks.Task<int> registerAsync(string usernama, string email, string password) {
            return base.Channel.registerAsync(usernama, email, password);
        }
        
        public int login(string username, string password) {
            return base.Channel.login(username, password);
        }
        
        public System.Threading.Tasks.Task<int> loginAsync(string username, string password) {
            return base.Channel.loginAsync(username, password);
        }
    }
}
