// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support
{

    /// <summary>The fabric VM power state.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerStateTypeConverter))]
    public partial struct VMPowerState :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Unknown".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Unknown", "Unknown", global::System.Management.Automation.CompletionResultType.ParameterValue, "Unknown");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Stopped".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Stopped", "Stopped", global::System.Management.Automation.CompletionResultType.ParameterValue, "Stopped");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Running".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Running", "Running", global::System.Management.Automation.CompletionResultType.ParameterValue, "Running");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Paused".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Paused", "Paused", global::System.Management.Automation.CompletionResultType.ParameterValue, "Paused");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SavedState".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SavedState", "SavedState", global::System.Management.Automation.CompletionResultType.ParameterValue, "SavedState");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Stopping".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Stopping", "Stopping", global::System.Management.Automation.CompletionResultType.ParameterValue, "Stopping");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Starting".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Starting", "Starting", global::System.Management.Automation.CompletionResultType.ParameterValue, "Starting");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Pausing".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Pausing", "Pausing", global::System.Management.Automation.CompletionResultType.ParameterValue, "Pausing");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Resuming".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Resuming", "Resuming", global::System.Management.Automation.CompletionResultType.ParameterValue, "Resuming");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Saving".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Saving", "Saving", global::System.Management.Automation.CompletionResultType.ParameterValue, "Saving");
            }
        }
    }
}