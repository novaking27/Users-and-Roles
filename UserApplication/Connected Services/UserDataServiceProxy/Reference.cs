﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserApplication.UserDataServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Role : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long RoleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long RoleID {
            get {
                return this.RoleIDField;
            }
            set {
                if ((this.RoleIDField.Equals(value) != true)) {
                    this.RoleIDField = value;
                    this.RaisePropertyChanged("RoleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string RoleName {
            get {
                return this.RoleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleNameField, value) != true)) {
                    this.RoleNameField = value;
                    this.RaisePropertyChanged("RoleName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserDataServiceProxy.UserDataServiceSoap")]
    public interface UserDataServiceSoap {
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateUserCredentials", ReplyAction="*")]
        UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponse ValidateUserCredentials(UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateUserCredentials", ReplyAction="*")]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponse> ValidateUserCredentialsAsync(UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRolesForUser", ReplyAction="*")]
        UserApplication.UserDataServiceProxy.GetRolesForUserResponse GetRolesForUser(UserApplication.UserDataServiceProxy.GetRolesForUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRolesForUser", ReplyAction="*")]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.GetRolesForUserResponse> GetRolesForUserAsync(UserApplication.UserDataServiceProxy.GetRolesForUserRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllRolesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllRoles", ReplyAction="*")]
        UserApplication.UserDataServiceProxy.GetAllRolesResponse GetAllRoles(UserApplication.UserDataServiceProxy.GetAllRolesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllRoles", ReplyAction="*")]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.GetAllRolesResponse> GetAllRolesAsync(UserApplication.UserDataServiceProxy.GetAllRolesRequest request);
        
        // CODEGEN: Generating message contract since element name roleID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddRoleToUser", ReplyAction="*")]
        UserApplication.UserDataServiceProxy.AddRoleToUserResponse AddRoleToUser(UserApplication.UserDataServiceProxy.AddRoleToUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddRoleToUser", ReplyAction="*")]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.AddRoleToUserResponse> AddRoleToUserAsync(UserApplication.UserDataServiceProxy.AddRoleToUserRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateUserCredentialsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateUserCredentials", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequestBody Body;
        
        public ValidateUserCredentialsRequest() {
        }
        
        public ValidateUserCredentialsRequest(UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateUserCredentialsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pass;
        
        public ValidateUserCredentialsRequestBody() {
        }
        
        public ValidateUserCredentialsRequestBody(string username, string pass) {
            this.username = username;
            this.pass = pass;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateUserCredentialsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateUserCredentialsResponse", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponseBody Body;
        
        public ValidateUserCredentialsResponse() {
        }
        
        public ValidateUserCredentialsResponse(UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateUserCredentialsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ValidateUserCredentialsResult;
        
        public ValidateUserCredentialsResponseBody() {
        }
        
        public ValidateUserCredentialsResponseBody(bool ValidateUserCredentialsResult) {
            this.ValidateUserCredentialsResult = ValidateUserCredentialsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRolesForUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRolesForUser", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.GetRolesForUserRequestBody Body;
        
        public GetRolesForUserRequest() {
        }
        
        public GetRolesForUserRequest(UserApplication.UserDataServiceProxy.GetRolesForUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRolesForUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        public GetRolesForUserRequestBody() {
        }
        
        public GetRolesForUserRequestBody(string username) {
            this.username = username;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRolesForUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRolesForUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.GetRolesForUserResponseBody Body;
        
        public GetRolesForUserResponse() {
        }
        
        public GetRolesForUserResponse(UserApplication.UserDataServiceProxy.GetRolesForUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRolesForUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public UserApplication.UserDataServiceProxy.ArrayOfString GetRolesForUserResult;
        
        public GetRolesForUserResponseBody() {
        }
        
        public GetRolesForUserResponseBody(UserApplication.UserDataServiceProxy.ArrayOfString GetRolesForUserResult) {
            this.GetRolesForUserResult = GetRolesForUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRolesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllRoles", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.GetAllRolesRequestBody Body;
        
        public GetAllRolesRequest() {
        }
        
        public GetAllRolesRequest(UserApplication.UserDataServiceProxy.GetAllRolesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRolesRequestBody {
        
        public GetAllRolesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRolesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllRolesResponse", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.GetAllRolesResponseBody Body;
        
        public GetAllRolesResponse() {
        }
        
        public GetAllRolesResponse(UserApplication.UserDataServiceProxy.GetAllRolesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllRolesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public UserApplication.UserDataServiceProxy.Role[] GetAllRolesResult;
        
        public GetAllRolesResponseBody() {
        }
        
        public GetAllRolesResponseBody(UserApplication.UserDataServiceProxy.Role[] GetAllRolesResult) {
            this.GetAllRolesResult = GetAllRolesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRoleToUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRoleToUser", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.AddRoleToUserRequestBody Body;
        
        public AddRoleToUserRequest() {
        }
        
        public AddRoleToUserRequest(UserApplication.UserDataServiceProxy.AddRoleToUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRoleToUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string roleID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string userID;
        
        public AddRoleToUserRequestBody() {
        }
        
        public AddRoleToUserRequestBody(string roleID, string userID) {
            this.roleID = roleID;
            this.userID = userID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRoleToUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRoleToUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public UserApplication.UserDataServiceProxy.AddRoleToUserResponseBody Body;
        
        public AddRoleToUserResponse() {
        }
        
        public AddRoleToUserResponse(UserApplication.UserDataServiceProxy.AddRoleToUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddRoleToUserResponseBody {
        
        public AddRoleToUserResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserDataServiceSoapChannel : UserApplication.UserDataServiceProxy.UserDataServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserDataServiceSoapClient : System.ServiceModel.ClientBase<UserApplication.UserDataServiceProxy.UserDataServiceSoap>, UserApplication.UserDataServiceProxy.UserDataServiceSoap {
        
        public UserDataServiceSoapClient() {
        }
        
        public UserDataServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserDataServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserDataServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserDataServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponse UserApplication.UserDataServiceProxy.UserDataServiceSoap.ValidateUserCredentials(UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest request) {
            return base.Channel.ValidateUserCredentials(request);
        }
        
        public bool ValidateUserCredentials(string username, string pass) {
            UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest inValue = new UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequestBody();
            inValue.Body.username = username;
            inValue.Body.pass = pass;
            UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponse retVal = ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).ValidateUserCredentials(inValue);
            return retVal.Body.ValidateUserCredentialsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponse> UserApplication.UserDataServiceProxy.UserDataServiceSoap.ValidateUserCredentialsAsync(UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest request) {
            return base.Channel.ValidateUserCredentialsAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.ValidateUserCredentialsResponse> ValidateUserCredentialsAsync(string username, string pass) {
            UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest inValue = new UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.ValidateUserCredentialsRequestBody();
            inValue.Body.username = username;
            inValue.Body.pass = pass;
            return ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).ValidateUserCredentialsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UserApplication.UserDataServiceProxy.GetRolesForUserResponse UserApplication.UserDataServiceProxy.UserDataServiceSoap.GetRolesForUser(UserApplication.UserDataServiceProxy.GetRolesForUserRequest request) {
            return base.Channel.GetRolesForUser(request);
        }
        
        public UserApplication.UserDataServiceProxy.ArrayOfString GetRolesForUser(string username) {
            UserApplication.UserDataServiceProxy.GetRolesForUserRequest inValue = new UserApplication.UserDataServiceProxy.GetRolesForUserRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.GetRolesForUserRequestBody();
            inValue.Body.username = username;
            UserApplication.UserDataServiceProxy.GetRolesForUserResponse retVal = ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).GetRolesForUser(inValue);
            return retVal.Body.GetRolesForUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.GetRolesForUserResponse> UserApplication.UserDataServiceProxy.UserDataServiceSoap.GetRolesForUserAsync(UserApplication.UserDataServiceProxy.GetRolesForUserRequest request) {
            return base.Channel.GetRolesForUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.GetRolesForUserResponse> GetRolesForUserAsync(string username) {
            UserApplication.UserDataServiceProxy.GetRolesForUserRequest inValue = new UserApplication.UserDataServiceProxy.GetRolesForUserRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.GetRolesForUserRequestBody();
            inValue.Body.username = username;
            return ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).GetRolesForUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UserApplication.UserDataServiceProxy.GetAllRolesResponse UserApplication.UserDataServiceProxy.UserDataServiceSoap.GetAllRoles(UserApplication.UserDataServiceProxy.GetAllRolesRequest request) {
            return base.Channel.GetAllRoles(request);
        }
        
        public UserApplication.UserDataServiceProxy.Role[] GetAllRoles() {
            UserApplication.UserDataServiceProxy.GetAllRolesRequest inValue = new UserApplication.UserDataServiceProxy.GetAllRolesRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.GetAllRolesRequestBody();
            UserApplication.UserDataServiceProxy.GetAllRolesResponse retVal = ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).GetAllRoles(inValue);
            return retVal.Body.GetAllRolesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.GetAllRolesResponse> UserApplication.UserDataServiceProxy.UserDataServiceSoap.GetAllRolesAsync(UserApplication.UserDataServiceProxy.GetAllRolesRequest request) {
            return base.Channel.GetAllRolesAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.GetAllRolesResponse> GetAllRolesAsync() {
            UserApplication.UserDataServiceProxy.GetAllRolesRequest inValue = new UserApplication.UserDataServiceProxy.GetAllRolesRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.GetAllRolesRequestBody();
            return ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).GetAllRolesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UserApplication.UserDataServiceProxy.AddRoleToUserResponse UserApplication.UserDataServiceProxy.UserDataServiceSoap.AddRoleToUser(UserApplication.UserDataServiceProxy.AddRoleToUserRequest request) {
            return base.Channel.AddRoleToUser(request);
        }
        
        public void AddRoleToUser(string roleID, string userID) {
            UserApplication.UserDataServiceProxy.AddRoleToUserRequest inValue = new UserApplication.UserDataServiceProxy.AddRoleToUserRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.AddRoleToUserRequestBody();
            inValue.Body.roleID = roleID;
            inValue.Body.userID = userID;
            UserApplication.UserDataServiceProxy.AddRoleToUserResponse retVal = ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).AddRoleToUser(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.AddRoleToUserResponse> UserApplication.UserDataServiceProxy.UserDataServiceSoap.AddRoleToUserAsync(UserApplication.UserDataServiceProxy.AddRoleToUserRequest request) {
            return base.Channel.AddRoleToUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserApplication.UserDataServiceProxy.AddRoleToUserResponse> AddRoleToUserAsync(string roleID, string userID) {
            UserApplication.UserDataServiceProxy.AddRoleToUserRequest inValue = new UserApplication.UserDataServiceProxy.AddRoleToUserRequest();
            inValue.Body = new UserApplication.UserDataServiceProxy.AddRoleToUserRequestBody();
            inValue.Body.roleID = roleID;
            inValue.Body.userID = userID;
            return ((UserApplication.UserDataServiceProxy.UserDataServiceSoap)(this)).AddRoleToUserAsync(inValue);
        }
    }
}
