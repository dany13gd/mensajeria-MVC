﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MensajeriaMVC.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllContacts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllContacts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllContacts", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllContactsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSingleContact", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSingleContact(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSingleContact", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSingleContactAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteContact", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet DeleteContact(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteContact", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> DeleteContactAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateContact", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet CreateContact(
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateContact", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> CreateContactAsync(
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateContact", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet UpdateContact(
                    int id, 
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateContact", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> UpdateContactAsync(
                    int id, 
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : MensajeriaMVC.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<MensajeriaMVC.ServiceReference1.WebService1Soap>, MensajeriaMVC.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetAllContacts() {
            return base.Channel.GetAllContacts();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllContactsAsync() {
            return base.Channel.GetAllContactsAsync();
        }
        
        public System.Data.DataSet GetSingleContact(string name) {
            return base.Channel.GetSingleContact(name);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSingleContactAsync(string name) {
            return base.Channel.GetSingleContactAsync(name);
        }
        
        public System.Data.DataSet DeleteContact(int id) {
            return base.Channel.DeleteContact(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DeleteContactAsync(int id) {
            return base.Channel.DeleteContactAsync(id);
        }
        
        public System.Data.DataSet CreateContact(
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen) {
            return base.Channel.CreateContact(name, organization, position, storeType, email, showAs, website, imAddress, phoneWork, phoneHome, faxWork, phoneMobile, workAddress, correspondence, notes, imagen);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> CreateContactAsync(
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen) {
            return base.Channel.CreateContactAsync(name, organization, position, storeType, email, showAs, website, imAddress, phoneWork, phoneHome, faxWork, phoneMobile, workAddress, correspondence, notes, imagen);
        }
        
        public System.Data.DataSet UpdateContact(
                    int id, 
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen) {
            return base.Channel.UpdateContact(id, name, organization, position, storeType, email, showAs, website, imAddress, phoneWork, phoneHome, faxWork, phoneMobile, workAddress, correspondence, notes, imagen);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UpdateContactAsync(
                    int id, 
                    string name, 
                    string organization, 
                    string position, 
                    string storeType, 
                    string email, 
                    string showAs, 
                    string website, 
                    string imAddress, 
                    string phoneWork, 
                    string phoneHome, 
                    string faxWork, 
                    string phoneMobile, 
                    string workAddress, 
                    int correspondence, 
                    string notes, 
                    string imagen) {
            return base.Channel.UpdateContactAsync(id, name, organization, position, storeType, email, showAs, website, imAddress, phoneWork, phoneHome, faxWork, phoneMobile, workAddress, correspondence, notes, imagen);
        }
    }
}
