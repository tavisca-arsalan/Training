﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tavisca.Model.EmployeeManagementService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime JoiningDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tavisca.Model.EmployeeManagementService.Remark[] RemarksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
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
        public System.DateTime JoiningDate {
            get {
                return this.JoiningDateField;
            }
            set {
                if ((this.JoiningDateField.Equals(value) != true)) {
                    this.JoiningDateField = value;
                    this.RaisePropertyChanged("JoiningDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Tavisca.Model.EmployeeManagementService.Remark[] Remarks {
            get {
                return this.RemarksField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarksField, value) != true)) {
                    this.RemarksField = value;
                    this.RaisePropertyChanged("Remarks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Remark", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    public partial class Remark : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateTimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
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
        public System.DateTime CreateTimeStamp {
            get {
                return this.CreateTimeStampField;
            }
            set {
                if ((this.CreateTimeStampField.Equals(value) != true)) {
                    this.CreateTimeStampField = value;
                    this.RaisePropertyChanged("CreateTimeStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Tavisca.Model.EmployeeManagementService.RemarkResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Tavisca.Model.EmployeeManagementService.EmployeeResponse))]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tavisca.Model.EmployeeManagementService.Status StatusField;
        
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
        public Tavisca.Model.EmployeeManagementService.Status Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    public partial class Status : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusCodeField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatusCode {
            get {
                return this.StatusCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusCodeField, value) != true)) {
                    this.StatusCodeField = value;
                    this.RaisePropertyChanged("StatusCode");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RemarkResponse", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    public partial class RemarkResponse : Tavisca.Model.EmployeeManagementService.Result {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tavisca.Model.EmployeeManagementService.Remark RemarkField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Tavisca.Model.EmployeeManagementService.Remark Remark {
            get {
                return this.RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkField, value) != true)) {
                    this.RemarkField = value;
                    this.RaisePropertyChanged("Remark");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeResponse", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    public partial class EmployeeResponse : Tavisca.Model.EmployeeManagementService.Result {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tavisca.Model.EmployeeManagementService.Employee EmployeeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Tavisca.Model.EmployeeManagementService.Employee Employee {
            get {
                return this.EmployeeField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeField, value) != true)) {
                    this.EmployeeField = value;
                    this.RaisePropertyChanged("Employee");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Credentials", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    public partial class Credentials : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string EmailId {
            get {
                return this.EmailIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIdField, value) != true)) {
                    this.EmailIdField = value;
                    this.RaisePropertyChanged("EmailId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CredentialModifier", Namespace="http://schemas.datacontract.org/2004/07/Tavisca.EmployeeManagement.DataContract")]
    [System.SerializableAttribute()]
    public partial class CredentialModifier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NewPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OldPasswordField;
        
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
        public string EmailId {
            get {
                return this.EmailIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIdField, value) != true)) {
                    this.EmailIdField = value;
                    this.RaisePropertyChanged("EmailId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NewPassword {
            get {
                return this.NewPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.NewPasswordField, value) != true)) {
                    this.NewPasswordField = value;
                    this.RaisePropertyChanged("NewPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OldPassword {
            get {
                return this.OldPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.OldPasswordField, value) != true)) {
                    this.OldPasswordField = value;
                    this.RaisePropertyChanged("OldPassword");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeManagementService.IEmployeeManagementService")]
    public interface IEmployeeManagementService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/Create", ReplyAction="http://tempuri.org/IEmployeeManagementService/CreateResponse")]
        Tavisca.Model.EmployeeManagementService.EmployeeResponse Create(Tavisca.Model.EmployeeManagementService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/Create", ReplyAction="http://tempuri.org/IEmployeeManagementService/CreateResponse")]
        System.Threading.Tasks.Task<Tavisca.Model.EmployeeManagementService.EmployeeResponse> CreateAsync(Tavisca.Model.EmployeeManagementService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/AddRemark", ReplyAction="http://tempuri.org/IEmployeeManagementService/AddRemarkResponse")]
        Tavisca.Model.EmployeeManagementService.RemarkResponse AddRemark(string employeeId, Tavisca.Model.EmployeeManagementService.Remark remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/AddRemark", ReplyAction="http://tempuri.org/IEmployeeManagementService/AddRemarkResponse")]
        System.Threading.Tasks.Task<Tavisca.Model.EmployeeManagementService.RemarkResponse> AddRemarkAsync(string employeeId, Tavisca.Model.EmployeeManagementService.Remark remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/CheckCredentials", ReplyAction="http://tempuri.org/IEmployeeManagementService/CheckCredentialsResponse")]
        Tavisca.Model.EmployeeManagementService.EmployeeResponse CheckCredentials(Tavisca.Model.EmployeeManagementService.Credentials credentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/CheckCredentials", ReplyAction="http://tempuri.org/IEmployeeManagementService/CheckCredentialsResponse")]
        System.Threading.Tasks.Task<Tavisca.Model.EmployeeManagementService.EmployeeResponse> CheckCredentialsAsync(Tavisca.Model.EmployeeManagementService.Credentials credentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/ModifyCredentials", ReplyAction="http://tempuri.org/IEmployeeManagementService/ModifyCredentialsResponse")]
        string ModifyCredentials(Tavisca.Model.EmployeeManagementService.CredentialModifier newCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManagementService/ModifyCredentials", ReplyAction="http://tempuri.org/IEmployeeManagementService/ModifyCredentialsResponse")]
        System.Threading.Tasks.Task<string> ModifyCredentialsAsync(Tavisca.Model.EmployeeManagementService.CredentialModifier newCredentials);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeManagementServiceChannel : Tavisca.Model.EmployeeManagementService.IEmployeeManagementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeManagementServiceClient : System.ServiceModel.ClientBase<Tavisca.Model.EmployeeManagementService.IEmployeeManagementService>, Tavisca.Model.EmployeeManagementService.IEmployeeManagementService {
        
        public EmployeeManagementServiceClient() {
        }
        
        public EmployeeManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Tavisca.Model.EmployeeManagementService.EmployeeResponse Create(Tavisca.Model.EmployeeManagementService.Employee employee) {
            return base.Channel.Create(employee);
        }
        
        public System.Threading.Tasks.Task<Tavisca.Model.EmployeeManagementService.EmployeeResponse> CreateAsync(Tavisca.Model.EmployeeManagementService.Employee employee) {
            return base.Channel.CreateAsync(employee);
        }
        
        public Tavisca.Model.EmployeeManagementService.RemarkResponse AddRemark(string employeeId, Tavisca.Model.EmployeeManagementService.Remark remark) {
            return base.Channel.AddRemark(employeeId, remark);
        }
        
        public System.Threading.Tasks.Task<Tavisca.Model.EmployeeManagementService.RemarkResponse> AddRemarkAsync(string employeeId, Tavisca.Model.EmployeeManagementService.Remark remark) {
            return base.Channel.AddRemarkAsync(employeeId, remark);
        }
        
        public Tavisca.Model.EmployeeManagementService.EmployeeResponse CheckCredentials(Tavisca.Model.EmployeeManagementService.Credentials credentials) {
            return base.Channel.CheckCredentials(credentials);
        }
        
        public System.Threading.Tasks.Task<Tavisca.Model.EmployeeManagementService.EmployeeResponse> CheckCredentialsAsync(Tavisca.Model.EmployeeManagementService.Credentials credentials) {
            return base.Channel.CheckCredentialsAsync(credentials);
        }
        
        public string ModifyCredentials(Tavisca.Model.EmployeeManagementService.CredentialModifier newCredentials) {
            return base.Channel.ModifyCredentials(newCredentials);
        }
        
        public System.Threading.Tasks.Task<string> ModifyCredentialsAsync(Tavisca.Model.EmployeeManagementService.CredentialModifier newCredentials) {
            return base.Channel.ModifyCredentialsAsync(newCredentials);
        }
    }
}
