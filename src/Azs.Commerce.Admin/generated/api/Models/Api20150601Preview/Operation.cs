namespace Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Extensions;

    /// <summary>Describes the supported REST operation.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplay _display;

        /// <summary>
        /// Contains the localized display information for this particular operation or action.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.Display()); set => this._display = value; }

        /// <summary>
        /// The localized, friendly description for the operation. The description will be displayed to the user. It should be thorough
        /// and concise for used in both tooltips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Description = value ?? null; }

        /// <summary>
        /// The localized, friendly name for the operation. Use the name as it will be displayed to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>
        /// The localized, friendly version of the resource provider name. The provider name is expected to include the name of the
        /// publisher or company responsible. The provider name format should use title case and begin with "Microsoft" for first-party
        /// services. For example, the provider name may be"Microsoft Monitoring Insights" or "Microsoft Compute".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>
        /// The localized, friendly version of the resource type related to this action or operation; the resource type should match
        /// the public documentation for the resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplay Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.Display()); set { {_display = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the operation performed on the object. The name should match the action name that appears in RBAC or the event
        /// service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Describes the supported REST operation.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The localized, friendly description for the operation. The description will be displayed to the user. It should be thorough
        /// and concise for used in both tooltips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized, friendly description for the operation. The description will be displayed to the user. It should be thorough and concise for used in both tooltips and detailed views.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>
        /// The localized, friendly name for the operation. Use the name as it will be displayed to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized, friendly name for the operation. Use the name as it will be displayed to the user.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>
        /// The localized, friendly version of the resource provider name. The provider name is expected to include the name of the
        /// publisher or company responsible. The provider name format should use title case and begin with "Microsoft" for first-party
        /// services. For example, the provider name may be"Microsoft Monitoring Insights" or "Microsoft Compute".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized, friendly version of the resource provider name. The provider name is expected to include the name of the publisher or company responsible. The provider name format should use title case and begin with ""Microsoft"" for first-party services. For example, the provider name may be""Microsoft Monitoring Insights"" or ""Microsoft Compute"".",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>
        /// The localized, friendly version of the resource type related to this action or operation; the resource type should match
        /// the public documentation for the resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized, friendly version of the resource type related to this action or operation; the resource type should match the public documentation for the resource provider.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>
        /// The name of the operation performed on the object. The name should match the action name that appears in RBAC or the event
        /// service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the operation performed on the object. The name should match the action name that appears in RBAC or the event service.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Describes the supported REST operation.
    internal partial interface IOperationInternal

    {
        /// <summary>
        /// Contains the localized display information for this particular operation or action.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IDisplay Display { get; set; }
        /// <summary>
        /// The localized, friendly description for the operation. The description will be displayed to the user. It should be thorough
        /// and concise for used in both tooltips and detailed views.
        /// </summary>
        string DisplayDescription { get; set; }
        /// <summary>
        /// The localized, friendly name for the operation. Use the name as it will be displayed to the user.
        /// </summary>
        string DisplayOperation { get; set; }
        /// <summary>
        /// The localized, friendly version of the resource provider name. The provider name is expected to include the name of the
        /// publisher or company responsible. The provider name format should use title case and begin with "Microsoft" for first-party
        /// services. For example, the provider name may be"Microsoft Monitoring Insights" or "Microsoft Compute".
        /// </summary>
        string DisplayProvider { get; set; }
        /// <summary>
        /// The localized, friendly version of the resource type related to this action or operation; the resource type should match
        /// the public documentation for the resource provider.
        /// </summary>
        string DisplayResource { get; set; }
        /// <summary>
        /// The name of the operation performed on the object. The name should match the action name that appears in RBAC or the event
        /// service.
        /// </summary>
        string Name { get; set; }

    }
}