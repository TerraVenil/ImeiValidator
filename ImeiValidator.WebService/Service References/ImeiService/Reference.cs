﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImeiValidator.WebService.ImeiService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ucrf.gov.ua/webservices/", ConfigurationName="ImeiService.MicsServiceSoap")]
    public interface MicsServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ucrf.gov.ua/webservices/GetServiceVersion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetServiceVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ucrf.gov.ua/webservices/GetServiceVersion", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetServiceVersionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ucrf.gov.ua/webservices/GetItemStatusByImei", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetItemStatusByImei(string imei);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ucrf.gov.ua/webservices/GetItemStatusByImei", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetItemStatusByImeiAsync(string imei);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MicsServiceSoapChannel : ImeiValidator.WebService.ImeiService.MicsServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MicsServiceSoapClient : System.ServiceModel.ClientBase<ImeiValidator.WebService.ImeiService.MicsServiceSoap>, ImeiValidator.WebService.ImeiService.MicsServiceSoap {
        
        public MicsServiceSoapClient() {
        }
        
        public MicsServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MicsServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MicsServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MicsServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetServiceVersion() {
            return base.Channel.GetServiceVersion();
        }
        
        public System.Threading.Tasks.Task<string> GetServiceVersionAsync() {
            return base.Channel.GetServiceVersionAsync();
        }
        
        public string GetItemStatusByImei(string imei) {
            return base.Channel.GetItemStatusByImei(imei);
        }
        
        public System.Threading.Tasks.Task<string> GetItemStatusByImeiAsync(string imei) {
            return base.Channel.GetItemStatusByImeiAsync(imei);
        }
    }
}
