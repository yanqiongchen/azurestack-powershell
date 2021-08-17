// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support
{

    /// <summary>State of the update run.</summary>
    public partial struct UpdateRunState :
        System.IEquatable<UpdateRunState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState InProgress = @"InProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState Unknown = @"Unknown";

        /// <summary>the value for an instance of the <see cref="UpdateRunState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UpdateRunState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpdateRunState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UpdateRunState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UpdateRunState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UpdateRunState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UpdateRunState && Equals((UpdateRunState)obj);
        }

        /// <summary>Returns hashCode for enum UpdateRunState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UpdateRunState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="UpdateRunState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UpdateRunState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UpdateRunState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpdateRunState" />.</param>

        public static implicit operator UpdateRunState(string value)
        {
            return new UpdateRunState(value);
        }

        /// <summary>Implicit operator to convert UpdateRunState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UpdateRunState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UpdateRunState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState e1, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UpdateRunState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState e1, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState e2)
        {
            return e2.Equals(e1);
        }
    }
}