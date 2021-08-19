// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    public partial class SubscriptionIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionIdentityInternal
    {

        /// <summary>Backing field for <see cref="DelegatedProviderId" /> property.</summary>
        private string _delegatedProviderId;

        /// <summary>Id of the delegated provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string DelegatedProviderId { get => this._delegatedProviderId; set => this._delegatedProviderId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="OfferName" /> property.</summary>
        private string _offerName;

        /// <summary>Name of the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string OfferName { get => this._offerName; set => this._offerName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Id of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="SubscriptionIdentity" /> instance.</summary>
        public SubscriptionIdentity()
        {

        }
    }
    public partial interface ISubscriptionIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable
    {
        /// <summary>Id of the delegated provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the delegated provider.",
        SerializedName = @"delegatedProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedProviderId { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Name of the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the offer.",
        SerializedName = @"offerName",
        PossibleTypes = new [] { typeof(string) })]
        string OfferName { get; set; }
        /// <summary>Id of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface ISubscriptionIdentityInternal

    {
        /// <summary>Id of the delegated provider.</summary>
        string DelegatedProviderId { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>Name of the offer.</summary>
        string OfferName { get; set; }
        /// <summary>Id of the subscription.</summary>
        string SubscriptionId { get; set; }

    }
}