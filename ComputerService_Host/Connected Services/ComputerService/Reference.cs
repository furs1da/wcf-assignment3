﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerService_Host.ComputerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Computer", Namespace="http://schemas.datacontract.org/2004/07/WcfService_8703133")]
    [System.SerializableAttribute()]
    public partial class Computer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisplayResolutionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HardDriveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ScreenSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UuidField;
        
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
        public int Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((this.BrandField.Equals(value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayResolution {
            get {
                return this.DisplayResolutionField;
            }
            set {
                if ((object.ReferenceEquals(this.DisplayResolutionField, value) != true)) {
                    this.DisplayResolutionField = value;
                    this.RaisePropertyChanged("DisplayResolution");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HardDrive {
            get {
                return this.HardDriveField;
            }
            set {
                if ((object.ReferenceEquals(this.HardDriveField, value) != true)) {
                    this.HardDriveField = value;
                    this.RaisePropertyChanged("HardDrive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Os {
            get {
                return this.OsField;
            }
            set {
                if ((this.OsField.Equals(value) != true)) {
                    this.OsField = value;
                    this.RaisePropertyChanged("Os");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ram {
            get {
                return this.RamField;
            }
            set {
                if ((object.ReferenceEquals(this.RamField, value) != true)) {
                    this.RamField = value;
                    this.RaisePropertyChanged("Ram");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ScreenSize {
            get {
                return this.ScreenSizeField;
            }
            set {
                if ((object.ReferenceEquals(this.ScreenSizeField, value) != true)) {
                    this.ScreenSizeField = value;
                    this.RaisePropertyChanged("ScreenSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uuid {
            get {
                return this.UuidField;
            }
            set {
                if ((object.ReferenceEquals(this.UuidField, value) != true)) {
                    this.UuidField = value;
                    this.RaisePropertyChanged("Uuid");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Brand", Namespace="http://schemas.datacontract.org/2004/07/WcfService_8703133")]
    [System.SerializableAttribute()]
    public partial class Brand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OS", Namespace="http://schemas.datacontract.org/2004/07/WcfService_8703133")]
    [System.SerializableAttribute()]
    public partial class OS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ComputerService.IComputerService")]
    public interface IComputerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/AddComputer", ReplyAction="http://tempuri.org/IComputerService/AddComputerResponse")]
        string AddComputer(ComputerService_Host.ComputerService.Computer computer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/AddComputer", ReplyAction="http://tempuri.org/IComputerService/AddComputerResponse")]
        System.Threading.Tasks.Task<string> AddComputerAsync(ComputerService_Host.ComputerService.Computer computer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/UpdateComputer", ReplyAction="http://tempuri.org/IComputerService/UpdateComputerResponse")]
        string UpdateComputer(ComputerService_Host.ComputerService.Computer computer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/UpdateComputer", ReplyAction="http://tempuri.org/IComputerService/UpdateComputerResponse")]
        System.Threading.Tasks.Task<string> UpdateComputerAsync(ComputerService_Host.ComputerService.Computer computer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/DeleteComputer", ReplyAction="http://tempuri.org/IComputerService/DeleteComputerResponse")]
        string DeleteComputer(string uuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/DeleteComputer", ReplyAction="http://tempuri.org/IComputerService/DeleteComputerResponse")]
        System.Threading.Tasks.Task<string> DeleteComputerAsync(string uuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetComputer", ReplyAction="http://tempuri.org/IComputerService/GetComputerResponse")]
        ComputerService_Host.ComputerService.Computer GetComputer(string uuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetComputer", ReplyAction="http://tempuri.org/IComputerService/GetComputerResponse")]
        System.Threading.Tasks.Task<ComputerService_Host.ComputerService.Computer> GetComputerAsync(string uuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetAllComputers", ReplyAction="http://tempuri.org/IComputerService/GetAllComputersResponse")]
        ComputerService_Host.ComputerService.Computer[] GetAllComputers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetAllComputers", ReplyAction="http://tempuri.org/IComputerService/GetAllComputersResponse")]
        System.Threading.Tasks.Task<ComputerService_Host.ComputerService.Computer[]> GetAllComputersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetAllBrands", ReplyAction="http://tempuri.org/IComputerService/GetAllBrandsResponse")]
        ComputerService_Host.ComputerService.Brand[] GetAllBrands();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetAllBrands", ReplyAction="http://tempuri.org/IComputerService/GetAllBrandsResponse")]
        System.Threading.Tasks.Task<ComputerService_Host.ComputerService.Brand[]> GetAllBrandsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetAllOses", ReplyAction="http://tempuri.org/IComputerService/GetAllOsesResponse")]
        ComputerService_Host.ComputerService.OS[] GetAllOses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComputerService/GetAllOses", ReplyAction="http://tempuri.org/IComputerService/GetAllOsesResponse")]
        System.Threading.Tasks.Task<ComputerService_Host.ComputerService.OS[]> GetAllOsesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IComputerServiceChannel : ComputerService_Host.ComputerService.IComputerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ComputerServiceClient : System.ServiceModel.ClientBase<ComputerService_Host.ComputerService.IComputerService>, ComputerService_Host.ComputerService.IComputerService {
        
        public ComputerServiceClient() {
        }
        
        public ComputerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ComputerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComputerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComputerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddComputer(ComputerService_Host.ComputerService.Computer computer) {
            return base.Channel.AddComputer(computer);
        }
        
        public System.Threading.Tasks.Task<string> AddComputerAsync(ComputerService_Host.ComputerService.Computer computer) {
            return base.Channel.AddComputerAsync(computer);
        }
        
        public string UpdateComputer(ComputerService_Host.ComputerService.Computer computer) {
            return base.Channel.UpdateComputer(computer);
        }
        
        public System.Threading.Tasks.Task<string> UpdateComputerAsync(ComputerService_Host.ComputerService.Computer computer) {
            return base.Channel.UpdateComputerAsync(computer);
        }
        
        public string DeleteComputer(string uuid) {
            return base.Channel.DeleteComputer(uuid);
        }
        
        public System.Threading.Tasks.Task<string> DeleteComputerAsync(string uuid) {
            return base.Channel.DeleteComputerAsync(uuid);
        }
        
        public ComputerService_Host.ComputerService.Computer GetComputer(string uuid) {
            return base.Channel.GetComputer(uuid);
        }
        
        public System.Threading.Tasks.Task<ComputerService_Host.ComputerService.Computer> GetComputerAsync(string uuid) {
            return base.Channel.GetComputerAsync(uuid);
        }
        
        public ComputerService_Host.ComputerService.Computer[] GetAllComputers() {
            return base.Channel.GetAllComputers();
        }
        
        public System.Threading.Tasks.Task<ComputerService_Host.ComputerService.Computer[]> GetAllComputersAsync() {
            return base.Channel.GetAllComputersAsync();
        }
        
        public ComputerService_Host.ComputerService.Brand[] GetAllBrands() {
            return base.Channel.GetAllBrands();
        }
        
        public System.Threading.Tasks.Task<ComputerService_Host.ComputerService.Brand[]> GetAllBrandsAsync() {
            return base.Channel.GetAllBrandsAsync();
        }
        
        public ComputerService_Host.ComputerService.OS[] GetAllOses() {
            return base.Channel.GetAllOses();
        }
        
        public System.Threading.Tasks.Task<ComputerService_Host.ComputerService.OS[]> GetAllOsesAsync() {
            return base.Channel.GetAllOsesAsync();
        }
    }
}
