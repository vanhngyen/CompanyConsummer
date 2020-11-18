﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyConsummer.EmployeeServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/CompanyService")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CompanyConsummer.EmployeeServices.Department DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> DepartmentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SalaryField;
        
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
        public CompanyConsummer.EmployeeServices.Department Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> DepartmentID {
            get {
                return this.DepartmentIDField;
            }
            set {
                if ((this.DepartmentIDField.Equals(value) != true)) {
                    this.DepartmentIDField = value;
                    this.RaisePropertyChanged("DepartmentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Department", Namespace="http://schemas.datacontract.org/2004/07/CompanyService")]
    [System.SerializableAttribute()]
    public partial class Department : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DepartmentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CompanyConsummer.EmployeeServices.Employee[] EmployeesField;
        
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
        public int DepartmentID {
            get {
                return this.DepartmentIDField;
            }
            set {
                if ((this.DepartmentIDField.Equals(value) != true)) {
                    this.DepartmentIDField = value;
                    this.RaisePropertyChanged("DepartmentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyConsummer.EmployeeServices.Employee[] Employees {
            get {
                return this.EmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeesField, value) != true)) {
                    this.EmployeesField = value;
                    this.RaisePropertyChanged("Employees");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServices.ICompanyService")]
    public interface ICompanyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/getEmployees", ReplyAction="http://tempuri.org/ICompanyService/getEmployeesResponse")]
        CompanyConsummer.EmployeeServices.Employee[] getEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/getEmployees", ReplyAction="http://tempuri.org/ICompanyService/getEmployeesResponse")]
        System.Threading.Tasks.Task<CompanyConsummer.EmployeeServices.Employee[]> getEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/createEmployee", ReplyAction="http://tempuri.org/ICompanyService/createEmployeeResponse")]
        bool createEmployee(CompanyConsummer.EmployeeServices.Employee newEmployee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/createEmployee", ReplyAction="http://tempuri.org/ICompanyService/createEmployeeResponse")]
        System.Threading.Tasks.Task<bool> createEmployeeAsync(CompanyConsummer.EmployeeServices.Employee newEmployee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/editEmployee", ReplyAction="http://tempuri.org/ICompanyService/editEmployeeResponse")]
        bool editEmployee(string id, CompanyConsummer.EmployeeServices.Employee newEmployee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/editEmployee", ReplyAction="http://tempuri.org/ICompanyService/editEmployeeResponse")]
        System.Threading.Tasks.Task<bool> editEmployeeAsync(string id, CompanyConsummer.EmployeeServices.Employee newEmployee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/deleteEmployee", ReplyAction="http://tempuri.org/ICompanyService/deleteEmployeeResponse")]
        bool deleteEmployee(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/deleteEmployee", ReplyAction="http://tempuri.org/ICompanyService/deleteEmployeeResponse")]
        System.Threading.Tasks.Task<bool> deleteEmployeeAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/getDepartments", ReplyAction="http://tempuri.org/ICompanyService/getDepartmentsResponse")]
        CompanyConsummer.EmployeeServices.Department[] getDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/getDepartments", ReplyAction="http://tempuri.org/ICompanyService/getDepartmentsResponse")]
        System.Threading.Tasks.Task<CompanyConsummer.EmployeeServices.Department[]> getDepartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/createDepartment", ReplyAction="http://tempuri.org/ICompanyService/createDepartmentResponse")]
        bool createDepartment(CompanyConsummer.EmployeeServices.Department newDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/createDepartment", ReplyAction="http://tempuri.org/ICompanyService/createDepartmentResponse")]
        System.Threading.Tasks.Task<bool> createDepartmentAsync(CompanyConsummer.EmployeeServices.Department newDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/editDepartment", ReplyAction="http://tempuri.org/ICompanyService/editDepartmentResponse")]
        bool editDepartment(string id, CompanyConsummer.EmployeeServices.Department newDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/editDepartment", ReplyAction="http://tempuri.org/ICompanyService/editDepartmentResponse")]
        System.Threading.Tasks.Task<bool> editDepartmentAsync(string id, CompanyConsummer.EmployeeServices.Department newDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/deleteDepartment", ReplyAction="http://tempuri.org/ICompanyService/deleteDepartmentResponse")]
        bool deleteDepartment(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/deleteDepartment", ReplyAction="http://tempuri.org/ICompanyService/deleteDepartmentResponse")]
        System.Threading.Tasks.Task<bool> deleteDepartmentAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyServiceChannel : CompanyConsummer.EmployeeServices.ICompanyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyServiceClient : System.ServiceModel.ClientBase<CompanyConsummer.EmployeeServices.ICompanyService>, CompanyConsummer.EmployeeServices.ICompanyService {
        
        public CompanyServiceClient() {
        }
        
        public CompanyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CompanyConsummer.EmployeeServices.Employee[] getEmployees() {
            return base.Channel.getEmployees();
        }
        
        public System.Threading.Tasks.Task<CompanyConsummer.EmployeeServices.Employee[]> getEmployeesAsync() {
            return base.Channel.getEmployeesAsync();
        }
        
        public bool createEmployee(CompanyConsummer.EmployeeServices.Employee newEmployee) {
            return base.Channel.createEmployee(newEmployee);
        }
        
        public System.Threading.Tasks.Task<bool> createEmployeeAsync(CompanyConsummer.EmployeeServices.Employee newEmployee) {
            return base.Channel.createEmployeeAsync(newEmployee);
        }
        
        public bool editEmployee(string id, CompanyConsummer.EmployeeServices.Employee newEmployee) {
            return base.Channel.editEmployee(id, newEmployee);
        }
        
        public System.Threading.Tasks.Task<bool> editEmployeeAsync(string id, CompanyConsummer.EmployeeServices.Employee newEmployee) {
            return base.Channel.editEmployeeAsync(id, newEmployee);
        }
        
        public bool deleteEmployee(string id) {
            return base.Channel.deleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteEmployeeAsync(string id) {
            return base.Channel.deleteEmployeeAsync(id);
        }
        
        public CompanyConsummer.EmployeeServices.Department[] getDepartments() {
            return base.Channel.getDepartments();
        }
        
        public System.Threading.Tasks.Task<CompanyConsummer.EmployeeServices.Department[]> getDepartmentsAsync() {
            return base.Channel.getDepartmentsAsync();
        }
        
        public bool createDepartment(CompanyConsummer.EmployeeServices.Department newDepartment) {
            return base.Channel.createDepartment(newDepartment);
        }
        
        public System.Threading.Tasks.Task<bool> createDepartmentAsync(CompanyConsummer.EmployeeServices.Department newDepartment) {
            return base.Channel.createDepartmentAsync(newDepartment);
        }
        
        public bool editDepartment(string id, CompanyConsummer.EmployeeServices.Department newDepartment) {
            return base.Channel.editDepartment(id, newDepartment);
        }
        
        public System.Threading.Tasks.Task<bool> editDepartmentAsync(string id, CompanyConsummer.EmployeeServices.Department newDepartment) {
            return base.Channel.editDepartmentAsync(id, newDepartment);
        }
        
        public bool deleteDepartment(string id) {
            return base.Channel.deleteDepartment(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteDepartmentAsync(string id) {
            return base.Channel.deleteDepartmentAsync(id);
        }
    }
}
