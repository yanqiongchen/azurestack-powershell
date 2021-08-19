namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.PowerShell;

    /// <summary>Managed Disk.</summary>
    [System.ComponentModel.TypeConverter(typeof(DiskTypeConverter))]
    public partial class Disk
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.Disk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDisk DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Disk(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.Disk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDisk DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Disk(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.Disk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Disk(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.DiskPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).SharePath = (string) content.GetValueForProperty("SharePath",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).SharePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ActualSizeGb = (long?) content.GetValueForProperty("ActualSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ActualSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ProvisionSizeGb = (long?) content.GetValueForProperty("ProvisionSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ProvisionSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ManagedBy = (string) content.GetValueForProperty("ManagedBy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ManagedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).UserResourceId = (string) content.GetValueForProperty("UserResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).UserResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskSku = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType?) content.GetValueForProperty("DiskSku",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskSku, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationSourceUri = (string) content.GetValueForProperty("CreationSourceUri",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationSourceUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationOption = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption?) content.GetValueForProperty("CreationOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationOption, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ExclusiveAllocatedSize = (long?) content.GetValueForProperty("ExclusiveAllocatedSize",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ExclusiveAllocatedSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.Disk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Disk(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.DiskPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).SharePath = (string) content.GetValueForProperty("SharePath",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).SharePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ActualSizeGb = (long?) content.GetValueForProperty("ActualSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ActualSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ProvisionSizeGb = (long?) content.GetValueForProperty("ProvisionSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ProvisionSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ManagedBy = (string) content.GetValueForProperty("ManagedBy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ManagedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).UserResourceId = (string) content.GetValueForProperty("UserResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).UserResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskSku = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType?) content.GetValueForProperty("DiskSku",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).DiskSku, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationSourceUri = (string) content.GetValueForProperty("CreationSourceUri",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationSourceUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationOption = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption?) content.GetValueForProperty("CreationOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).CreationOption, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ExclusiveAllocatedSize = (long?) content.GetValueForProperty("ExclusiveAllocatedSize",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal)this).ExclusiveAllocatedSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Disk" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDisk FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Managed Disk.
    [System.ComponentModel.TypeConverter(typeof(DiskTypeConverter))]
    public partial interface IDisk

    {

    }
}