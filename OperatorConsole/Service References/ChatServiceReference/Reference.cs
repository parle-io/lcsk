﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OperatorConsole.ChatServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatRequestEntity", Namespace="http://schemas.datacontract.org/2004/07/LiveChat.Entities")]
    [System.SerializableAttribute()]
    public partial class ChatRequestEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime RequestedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SendCopyOfChatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VisitorEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VisitorIpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VisitorNameField;
        
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
        public int DepartmentId {
            get {
                return this.DepartmentIdField;
            }
            set {
                if ((this.DepartmentIdField.Equals(value) != true)) {
                    this.DepartmentIdField = value;
                    this.RaisePropertyChanged("DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestedDate {
            get {
                return this.RequestedDateField;
            }
            set {
                if ((this.RequestedDateField.Equals(value) != true)) {
                    this.RequestedDateField = value;
                    this.RaisePropertyChanged("RequestedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SendCopyOfChat {
            get {
                return this.SendCopyOfChatField;
            }
            set {
                if ((this.SendCopyOfChatField.Equals(value) != true)) {
                    this.SendCopyOfChatField = value;
                    this.RaisePropertyChanged("SendCopyOfChat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisitorEmail {
            get {
                return this.VisitorEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.VisitorEmailField, value) != true)) {
                    this.VisitorEmailField = value;
                    this.RaisePropertyChanged("VisitorEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisitorIp {
            get {
                return this.VisitorIpField;
            }
            set {
                if ((object.ReferenceEquals(this.VisitorIpField, value) != true)) {
                    this.VisitorIpField = value;
                    this.RaisePropertyChanged("VisitorIp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisitorName {
            get {
                return this.VisitorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.VisitorNameField, value) != true)) {
                    this.VisitorNameField = value;
                    this.RaisePropertyChanged("VisitorName");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageEntity", Namespace="http://schemas.datacontract.org/2004/07/LiveChat.Entities")]
    [System.SerializableAttribute()]
    public partial class MessageEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChannelIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SendDateField;
        
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
        public string ChannelId {
            get {
                return this.ChannelIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ChannelIdField, value) != true)) {
                    this.ChannelIdField = value;
                    this.RaisePropertyChanged("ChannelId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FromName {
            get {
                return this.FromNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FromNameField, value) != true)) {
                    this.FromNameField = value;
                    this.RaisePropertyChanged("FromName");
                }
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
        public System.DateTime SendDate {
            get {
                return this.SendDateField;
            }
            set {
                if ((this.SendDateField.Equals(value) != true)) {
                    this.SendDateField = value;
                    this.RaisePropertyChanged("SendDate");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChatServiceReference.IChatService")]
    public interface IChatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/RequestChat", ReplyAction="http://tempuri.org/IChatService/RequestChatResponse")]
        string RequestChat(OperatorConsole.ChatServiceReference.ChatRequestEntity request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/WriteMessage", ReplyAction="http://tempuri.org/IChatService/WriteMessageResponse")]
        void WriteMessage(OperatorConsole.ChatServiceReference.MessageEntity msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetMessages", ReplyAction="http://tempuri.org/IChatService/GetMessagesResponse")]
        OperatorConsole.ChatServiceReference.MessageEntity[] GetMessages(string channelId, long lastId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/RemoveChatRequest", ReplyAction="http://tempuri.org/IChatService/RemoveChatRequestResponse")]
        void RemoveChatRequest(int requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/HasNewMessage", ReplyAction="http://tempuri.org/IChatService/HasNewMessageResponse")]
        bool HasNewMessage(string channelId, long lastId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IChatServiceChannel : OperatorConsole.ChatServiceReference.IChatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ChatServiceClient : System.ServiceModel.ClientBase<OperatorConsole.ChatServiceReference.IChatService>, OperatorConsole.ChatServiceReference.IChatService {
        
        public ChatServiceClient() {
        }
        
        public ChatServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string RequestChat(OperatorConsole.ChatServiceReference.ChatRequestEntity request) {
            return base.Channel.RequestChat(request);
        }
        
        public void WriteMessage(OperatorConsole.ChatServiceReference.MessageEntity msg) {
            base.Channel.WriteMessage(msg);
        }
        
        public OperatorConsole.ChatServiceReference.MessageEntity[] GetMessages(string channelId, long lastId) {
            return base.Channel.GetMessages(channelId, lastId);
        }
        
        public void RemoveChatRequest(int requestId) {
            base.Channel.RemoveChatRequest(requestId);
        }
        
        public bool HasNewMessage(string channelId, long lastId) {
            return base.Channel.HasNewMessage(channelId, lastId);
        }
    }
}
