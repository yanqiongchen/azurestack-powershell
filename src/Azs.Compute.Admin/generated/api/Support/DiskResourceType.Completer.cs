// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support
{

    /// <summary>Disk resource type.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceTypeTypeConverter))]
    public partial struct DiskResourceType :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Undefined".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Undefined", "Undefined", global::System.Management.Automation.CompletionResultType.ParameterValue, "Undefined");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Disk".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Disk", "Disk", global::System.Management.Automation.CompletionResultType.ParameterValue, "Disk");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Snapshot".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Snapshot", "Snapshot", global::System.Management.Automation.CompletionResultType.ParameterValue, "Snapshot");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "RestorePoint".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("RestorePoint", "RestorePoint", global::System.Management.Automation.CompletionResultType.ParameterValue, "RestorePoint");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ManagedBlob".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ManagedBlob", "ManagedBlob", global::System.Management.Automation.CompletionResultType.ParameterValue, "ManagedBlob");
            }
        }
    }
}