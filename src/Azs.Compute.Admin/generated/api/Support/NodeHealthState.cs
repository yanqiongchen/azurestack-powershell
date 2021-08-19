// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support
{

    /// <summary>The node health state.</summary>
    public partial struct NodeHealthState :
        System.IEquatable<NodeHealthState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState Down = @"Down";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState MaintenanceMode = @"MaintenanceMode";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState Unknown = @"Unknown";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState Up = @"Up";

        /// <summary>the value for an instance of the <see cref="NodeHealthState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to NodeHealthState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NodeHealthState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new NodeHealthState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type NodeHealthState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type NodeHealthState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is NodeHealthState && Equals((NodeHealthState)obj);
        }

        /// <summary>Returns hashCode for enum NodeHealthState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="NodeHealthState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private NodeHealthState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for NodeHealthState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to NodeHealthState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NodeHealthState" />.</param>

        public static implicit operator NodeHealthState(string value)
        {
            return new NodeHealthState(value);
        }

        /// <summary>Implicit operator to convert NodeHealthState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="NodeHealthState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum NodeHealthState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState e1, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum NodeHealthState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState e1, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState e2)
        {
            return e2.Equals(e1);
        }
    }
}