namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Product compatibility</summary>
    public partial class Compatibility
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="Compatibility" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Compatibility(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_isCompatible = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonBoolean>("isCompatible"), out var __jsonIsCompatible) ? (bool?)__jsonIsCompatible : IsCompatible;}
            {_message = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("message"), out var __jsonMessage) ? (string)__jsonMessage : (string)Message;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_issue = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonArray>("issues"), out var __jsonIssues) ? If( __jsonIssues as Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue) (__u is Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString __t ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue)(__t.ToString()) : ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue)""))) ))() : null : Issue;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility FromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json ? new Compatibility(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Compatibility" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Compatibility" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._isCompatible ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonBoolean((bool)this._isCompatible) : null, "isCompatible" ,container.Add );
            AddIf( null != (((object)this._message)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._message.ToString()) : null, "message" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            if (null != this._issue)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.XNodeArray();
                foreach( var __x in this._issue )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("issues",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}