﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.PHPSoapService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="127.0.0.1", ConfigurationName="PHPSoapService.mySOAPPortType")]
    public interface mySOAPPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/soap/index.php/dodajKsiazke", ReplyAction="*")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string dodajKsiazke(string Nazwa, string Autor, string Kategoria, string Lektura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/soap/index.php/dodajKsiazke", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> dodajKsiazkeAsync(string Nazwa, string Autor, string Kategoria, string Lektura);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface mySOAPPortTypeChannel : Client.PHPSoapService.mySOAPPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class mySOAPPortTypeClient : System.ServiceModel.ClientBase<Client.PHPSoapService.mySOAPPortType>, Client.PHPSoapService.mySOAPPortType {
        
        public mySOAPPortTypeClient() {
        }
        
        public mySOAPPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public mySOAPPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public mySOAPPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public mySOAPPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string dodajKsiazke(string Nazwa, string Autor, string Kategoria, string Lektura) {
            return base.Channel.dodajKsiazke(Nazwa, Autor, Kategoria, Lektura);
        }
        
        public System.Threading.Tasks.Task<string> dodajKsiazkeAsync(string Nazwa, string Autor, string Kategoria, string Lektura) {
            return base.Channel.dodajKsiazkeAsync(Nazwa, Autor, Kategoria, Lektura);
        }
    }
}
