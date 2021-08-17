namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>A pageable list of SLB MUX instances.</summary>
    public partial class SlbMuxInstanceList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstanceList,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstanceListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstance[] _value;

        /// <summary>List of SLB MUX instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstance[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SlbMuxInstanceList" /> instance.</summary>
        public SlbMuxInstanceList()
        {

        }
    }
    /// A pageable list of SLB MUX instances.
    public partial interface ISlbMuxInstanceList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of SLB MUX instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of SLB MUX instances.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstance) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstance[] Value { get; set; }

    }
    /// A pageable list of SLB MUX instances.
    internal partial interface ISlbMuxInstanceListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of SLB MUX instances.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstance[] Value { get; set; }

    }
}