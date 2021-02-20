﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace libraryclient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/libraryservice")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string author_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string book_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string student_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string student_nameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string author_name {
            get {
                return this.author_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.author_nameField, value) != true)) {
                    this.author_nameField = value;
                    this.RaisePropertyChanged("author_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string book_name {
            get {
                return this.book_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.book_nameField, value) != true)) {
                    this.book_nameField = value;
                    this.RaisePropertyChanged("book_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string price {
            get {
                return this.priceField;
            }
            set {
                if ((object.ReferenceEquals(this.priceField, value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string student_id {
            get {
                return this.student_idField;
            }
            set {
                if ((object.ReferenceEquals(this.student_idField, value) != true)) {
                    this.student_idField = value;
                    this.RaisePropertyChanged("student_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string student_name {
            get {
                return this.student_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.student_nameField, value) != true)) {
                    this.student_nameField = value;
                    this.RaisePropertyChanged("student_name");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddRecord", ReplyAction="http://tempuri.org/IService1/AddRecordResponse")]
        string AddRecord(libraryclient.ServiceReference1.Book bk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddRecord", ReplyAction="http://tempuri.org/IService1/AddRecordResponse")]
        System.Threading.Tasks.Task<string> AddRecordAsync(libraryclient.ServiceReference1.Book bk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRecords", ReplyAction="http://tempuri.org/IService1/GetRecordsResponse")]
        System.Data.DataSet GetRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRecords", ReplyAction="http://tempuri.org/IService1/GetRecordsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetRecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecords", ReplyAction="http://tempuri.org/IService1/DeleteRecordsResponse")]
        string DeleteRecords(libraryclient.ServiceReference1.Book bk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecords", ReplyAction="http://tempuri.org/IService1/DeleteRecordsResponse")]
        System.Threading.Tasks.Task<string> DeleteRecordsAsync(libraryclient.ServiceReference1.Book bk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchRecord", ReplyAction="http://tempuri.org/IService1/SearchRecordResponse")]
        System.Data.DataSet SearchRecord(libraryclient.ServiceReference1.Book bk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchRecord", ReplyAction="http://tempuri.org/IService1/SearchRecordResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchRecordAsync(libraryclient.ServiceReference1.Book bk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Updateinfo", ReplyAction="http://tempuri.org/IService1/UpdateinfoResponse")]
        string Updateinfo(libraryclient.ServiceReference1.Book bk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Updateinfo", ReplyAction="http://tempuri.org/IService1/UpdateinfoResponse")]
        System.Threading.Tasks.Task<string> UpdateinfoAsync(libraryclient.ServiceReference1.Book bk);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : libraryclient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<libraryclient.ServiceReference1.IService1>, libraryclient.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string AddRecord(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.AddRecord(bk);
        }
        
        public System.Threading.Tasks.Task<string> AddRecordAsync(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.AddRecordAsync(bk);
        }
        
        public System.Data.DataSet GetRecords() {
            return base.Channel.GetRecords();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetRecordsAsync() {
            return base.Channel.GetRecordsAsync();
        }
        
        public string DeleteRecords(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.DeleteRecords(bk);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRecordsAsync(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.DeleteRecordsAsync(bk);
        }
        
        public System.Data.DataSet SearchRecord(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.SearchRecord(bk);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchRecordAsync(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.SearchRecordAsync(bk);
        }
        
        public string Updateinfo(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.Updateinfo(bk);
        }
        
        public System.Threading.Tasks.Task<string> UpdateinfoAsync(libraryclient.ServiceReference1.Book bk) {
            return base.Channel.UpdateinfoAsync(bk);
        }
    }
}
