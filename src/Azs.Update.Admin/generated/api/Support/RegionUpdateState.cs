// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support
{

    /// <summary>State of the region in regard to update.</summary>
    public partial struct RegionUpdateState :
        System.IEquatable<RegionUpdateState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState AppliedSuccessfully = @"AppliedSuccessfully";

        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState AppliedUpdateAvailableSuccessfully = @"AppliedUpdateAvailableSuccessfully";

        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState Unknown = @"Unknown";

        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState UpdateFailed = @"UpdateFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState UpdateInProgress = @"UpdateInProgress";

        /// <summary>the value for an instance of the <see cref="RegionUpdateState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RegionUpdateState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RegionUpdateState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RegionUpdateState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RegionUpdateState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RegionUpdateState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RegionUpdateState && Equals((RegionUpdateState)obj);
        }

        /// <summary>Returns hashCode for enum RegionUpdateState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RegionUpdateState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RegionUpdateState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RegionUpdateState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RegionUpdateState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RegionUpdateState" />.</param>

        public static implicit operator RegionUpdateState(string value)
        {
            return new RegionUpdateState(value);
        }

        /// <summary>Implicit operator to convert RegionUpdateState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RegionUpdateState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RegionUpdateState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState e1, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RegionUpdateState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState e1, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState e2)
        {
            return e2.Equals(e1);
        }
    }
}