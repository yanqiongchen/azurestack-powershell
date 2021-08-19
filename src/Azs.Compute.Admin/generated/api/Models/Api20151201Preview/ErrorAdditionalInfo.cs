namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>The resource management error additional info.</summary>
    public partial class ErrorAdditionalInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IErrorAdditionalInfo,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IErrorAdditionalInfoInternal
    {

        /// <summary>Backing field for <see cref="Info" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.IAny _info;

        /// <summary>The additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.IAny Info { get => (this._info = this._info ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Any()); }

        /// <summary>Internal Acessors for Info</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IErrorAdditionalInfoInternal.Info { get => (this._info = this._info ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Any()); set { {_info = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IErrorAdditionalInfoInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The additional info type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ErrorAdditionalInfo" /> instance.</summary>
        public ErrorAdditionalInfo()
        {

        }
    }
    /// The resource management error additional info.
    public partial interface IErrorAdditionalInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The additional info.",
        SerializedName = @"info",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.IAny Info { get;  }
        /// <summary>The additional info type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The additional info type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The resource management error additional info.
    internal partial interface IErrorAdditionalInfoInternal

    {
        /// <summary>The additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.IAny Info { get; set; }
        /// <summary>The additional info type.</summary>
        string Type { get; set; }

    }
}