// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support
{

    /// <summary>Migration job status.</summary>
    public partial struct MigrationJobStatus :
        System.IEquatable<MigrationJobStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus Pending = @"Pending";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus Running = @"Running";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus Undefined = @"Undefined";

        /// <summary>the value for an instance of the <see cref="MigrationJobStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MigrationJobStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MigrationJobStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MigrationJobStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MigrationJobStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MigrationJobStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MigrationJobStatus && Equals((MigrationJobStatus)obj);
        }

        /// <summary>Returns hashCode for enum MigrationJobStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MigrationJobStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MigrationJobStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MigrationJobStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MigrationJobStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MigrationJobStatus" />.</param>

        public static implicit operator MigrationJobStatus(string value)
        {
            return new MigrationJobStatus(value);
        }

        /// <summary>Implicit operator to convert MigrationJobStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MigrationJobStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MigrationJobStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MigrationJobStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}