namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties of a Virtual Machine Extension Image.</summary>
    public partial class VMExtensionProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json ? new VMExtensionProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMExtensionProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMExtensionProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._sourceBlob ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) this._sourceBlob.ToJson(null,serializationMode) : null, "sourceBlob" ,container.Add );
            AddIf( null != (((object)this._vmosType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._vmosType.ToString()) : null, "vmOsType" ,container.Add );
            AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            AddIf( null != (((object)this._computeRole)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._computeRole.ToString()) : null, "computeRole" ,container.Add );
            AddIf( null != this._vMScaleSetEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonBoolean((bool)this._vMScaleSetEnabled) : null, "vmScaleSetEnabled" ,container.Add );
            AddIf( null != this._supportMultipleExtension ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonBoolean((bool)this._supportMultipleExtension) : null, "supportMultipleExtensions" ,container.Add );
            AddIf( null != this._isSystemExtension ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonBoolean((bool)this._isSystemExtension) : null, "isSystemExtension" ,container.Add );
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="VMExtensionProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMExtensionProperties(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sourceBlob = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject>("sourceBlob"), out var __jsonSourceBlob) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.AzureBlob.FromJson(__jsonSourceBlob) : SourceBlob;}
            {_vmosType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("vmOsType"), out var __jsonVMOSType) ? (string)__jsonVMOSType : (string)VmosType;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)Publisher;}
            {_computeRole = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("computeRole"), out var __jsonComputeRole) ? (string)__jsonComputeRole : (string)ComputeRole;}
            {_vMScaleSetEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonBoolean>("vmScaleSetEnabled"), out var __jsonVMScaleSetEnabled) ? (bool?)__jsonVMScaleSetEnabled : VMScaleSetEnabled;}
            {_supportMultipleExtension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonBoolean>("supportMultipleExtensions"), out var __jsonSupportMultipleExtensions) ? (bool?)__jsonSupportMultipleExtensions : SupportMultipleExtension;}
            {_isSystemExtension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonBoolean>("isSystemExtension"), out var __jsonIsSystemExtension) ? (bool?)__jsonIsSystemExtension : IsSystemExtension;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            AfterFromJson(json);
        }
    }
}