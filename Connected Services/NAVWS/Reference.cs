﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAVWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", ConfigurationName="NAVWS.PortalIntegration_Port")]
    public interface PortalIntegration_Port
    {
        
        // CODEGEN: Generating message contract since the wrapper name (DeleteSeminarData_Result) of message DeleteSeminarData_Result does not match the default value (DeleteSeminarData)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:DeleteSeminarData", ReplyAction="*")]
        NAVWS.DeleteSeminarData_Result DeleteSeminarData(NAVWS.DeleteSeminarData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:DeleteSeminarData", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.DeleteSeminarData_Result> DeleteSeminarDataAsync(NAVWS.DeleteSeminarData request);
        
        // CODEGEN: Generating message contract since the wrapper name (GetSeminarData_Result) of message GetSeminarData_Result does not match the default value (GetSeminarData)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:GetSeminarData", ReplyAction="*")]
        NAVWS.GetSeminarData_Result GetSeminarData(NAVWS.GetSeminarData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:GetSeminarData", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.GetSeminarData_Result> GetSeminarDataAsync(NAVWS.GetSeminarData request);
        
        // CODEGEN: Generating message contract since the wrapper name (InsertSeminarData_Result) of message InsertSeminarData_Result does not match the default value (InsertSeminarData)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:InsertSeminarData", ReplyAction="*")]
        NAVWS.InsertSeminarData_Result InsertSeminarData(NAVWS.InsertSeminarData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:InsertSeminarData", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.InsertSeminarData_Result> InsertSeminarDataAsync(NAVWS.InsertSeminarData request);
        
        // CODEGEN: Generating message contract since the wrapper name (UpdateSeminarData_Result) of message UpdateSeminarData_Result does not match the default value (UpdateSeminarData)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:UpdateSeminarData", ReplyAction="*")]
        NAVWS.UpdateSeminarData_Result UpdateSeminarData(NAVWS.UpdateSeminarData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:UpdateSeminarData", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.UpdateSeminarData_Result> UpdateSeminarDataAsync(NAVWS.UpdateSeminarData request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteSeminarData", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class DeleteSeminarData
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string docNo;
        
        public DeleteSeminarData()
        {
        }
        
        public DeleteSeminarData(string docNo)
        {
            this.docNo = docNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteSeminarData_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class DeleteSeminarData_Result
    {
        
        public DeleteSeminarData_Result()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSeminarData", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class GetSeminarData
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string docNo;
        
        public GetSeminarData()
        {
        }
        
        public GetSeminarData(string docNo)
        {
            this.docNo = docNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSeminarData_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class GetSeminarData_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string return_value;
        
        public GetSeminarData_Result()
        {
        }
        
        public GetSeminarData_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertSeminarData", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class InsertSeminarData
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string docNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=2)]
        public decimal seminar_Duration;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=3)]
        public int minimum_Participants;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=4)]
        public int maximum_Participants;
        
        public InsertSeminarData()
        {
        }
        
        public InsertSeminarData(string docNo, string name, decimal seminar_Duration, int minimum_Participants, int maximum_Participants)
        {
            this.docNo = docNo;
            this.name = name;
            this.seminar_Duration = seminar_Duration;
            this.minimum_Participants = minimum_Participants;
            this.maximum_Participants = maximum_Participants;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertSeminarData_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class InsertSeminarData_Result
    {
        
        public InsertSeminarData_Result()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateSeminarData", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class UpdateSeminarData
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string docNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=2)]
        public decimal seminar_Duration;
        
        public UpdateSeminarData()
        {
        }
        
        public UpdateSeminarData(string docNo, string name, decimal seminar_Duration)
        {
            this.docNo = docNo;
            this.name = name;
            this.seminar_Duration = seminar_Duration;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateSeminarData_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class UpdateSeminarData_Result
    {
        
        public UpdateSeminarData_Result()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface PortalIntegration_PortChannel : NAVWS.PortalIntegration_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class PortalIntegration_PortClient : System.ServiceModel.ClientBase<NAVWS.PortalIntegration_Port>, NAVWS.PortalIntegration_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PortalIntegration_PortClient() : 
                base(PortalIntegration_PortClient.GetDefaultBinding(), PortalIntegration_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.PortalIntegration_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(PortalIntegration_PortClient.GetBindingForEndpoint(endpointConfiguration), PortalIntegration_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PortalIntegration_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PortalIntegration_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.DeleteSeminarData_Result NAVWS.PortalIntegration_Port.DeleteSeminarData(NAVWS.DeleteSeminarData request)
        {
            return base.Channel.DeleteSeminarData(request);
        }
        
        public void DeleteSeminarData(string docNo)
        {
            NAVWS.DeleteSeminarData inValue = new NAVWS.DeleteSeminarData();
            inValue.docNo = docNo;
            NAVWS.DeleteSeminarData_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).DeleteSeminarData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.DeleteSeminarData_Result> NAVWS.PortalIntegration_Port.DeleteSeminarDataAsync(NAVWS.DeleteSeminarData request)
        {
            return base.Channel.DeleteSeminarDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.DeleteSeminarData_Result> DeleteSeminarDataAsync(string docNo)
        {
            NAVWS.DeleteSeminarData inValue = new NAVWS.DeleteSeminarData();
            inValue.docNo = docNo;
            return ((NAVWS.PortalIntegration_Port)(this)).DeleteSeminarDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.GetSeminarData_Result NAVWS.PortalIntegration_Port.GetSeminarData(NAVWS.GetSeminarData request)
        {
            return base.Channel.GetSeminarData(request);
        }
        
        public string GetSeminarData(string docNo)
        {
            NAVWS.GetSeminarData inValue = new NAVWS.GetSeminarData();
            inValue.docNo = docNo;
            NAVWS.GetSeminarData_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).GetSeminarData(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.GetSeminarData_Result> NAVWS.PortalIntegration_Port.GetSeminarDataAsync(NAVWS.GetSeminarData request)
        {
            return base.Channel.GetSeminarDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.GetSeminarData_Result> GetSeminarDataAsync(string docNo)
        {
            NAVWS.GetSeminarData inValue = new NAVWS.GetSeminarData();
            inValue.docNo = docNo;
            return ((NAVWS.PortalIntegration_Port)(this)).GetSeminarDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.InsertSeminarData_Result NAVWS.PortalIntegration_Port.InsertSeminarData(NAVWS.InsertSeminarData request)
        {
            return base.Channel.InsertSeminarData(request);
        }
        
        public void InsertSeminarData(string docNo, string name, decimal seminar_Duration, int minimum_Participants, int maximum_Participants)
        {
            NAVWS.InsertSeminarData inValue = new NAVWS.InsertSeminarData();
            inValue.docNo = docNo;
            inValue.name = name;
            inValue.seminar_Duration = seminar_Duration;
            inValue.minimum_Participants = minimum_Participants;
            inValue.maximum_Participants = maximum_Participants;
            NAVWS.InsertSeminarData_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).InsertSeminarData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.InsertSeminarData_Result> NAVWS.PortalIntegration_Port.InsertSeminarDataAsync(NAVWS.InsertSeminarData request)
        {
            return base.Channel.InsertSeminarDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.InsertSeminarData_Result> InsertSeminarDataAsync(string docNo, string name, decimal seminar_Duration, int minimum_Participants, int maximum_Participants)
        {
            NAVWS.InsertSeminarData inValue = new NAVWS.InsertSeminarData();
            inValue.docNo = docNo;
            inValue.name = name;
            inValue.seminar_Duration = seminar_Duration;
            inValue.minimum_Participants = minimum_Participants;
            inValue.maximum_Participants = maximum_Participants;
            return ((NAVWS.PortalIntegration_Port)(this)).InsertSeminarDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.UpdateSeminarData_Result NAVWS.PortalIntegration_Port.UpdateSeminarData(NAVWS.UpdateSeminarData request)
        {
            return base.Channel.UpdateSeminarData(request);
        }
        
        public void UpdateSeminarData(string docNo, string name, decimal seminar_Duration)
        {
            NAVWS.UpdateSeminarData inValue = new NAVWS.UpdateSeminarData();
            inValue.docNo = docNo;
            inValue.name = name;
            inValue.seminar_Duration = seminar_Duration;
            NAVWS.UpdateSeminarData_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).UpdateSeminarData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.UpdateSeminarData_Result> NAVWS.PortalIntegration_Port.UpdateSeminarDataAsync(NAVWS.UpdateSeminarData request)
        {
            return base.Channel.UpdateSeminarDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.UpdateSeminarData_Result> UpdateSeminarDataAsync(string docNo, string name, decimal seminar_Duration)
        {
            NAVWS.UpdateSeminarData inValue = new NAVWS.UpdateSeminarData();
            inValue.docNo = docNo;
            inValue.name = name;
            inValue.seminar_Duration = seminar_Duration;
            return ((NAVWS.PortalIntegration_Port)(this)).UpdateSeminarDataAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PortalIntegration_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PortalIntegration_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://jo:7047/BC240/WS/CRONUS International Ltd./Codeunit/PortalIntegration");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PortalIntegration_PortClient.GetBindingForEndpoint(EndpointConfiguration.PortalIntegration_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PortalIntegration_PortClient.GetEndpointAddress(EndpointConfiguration.PortalIntegration_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            PortalIntegration_Port,
        }
    }
}