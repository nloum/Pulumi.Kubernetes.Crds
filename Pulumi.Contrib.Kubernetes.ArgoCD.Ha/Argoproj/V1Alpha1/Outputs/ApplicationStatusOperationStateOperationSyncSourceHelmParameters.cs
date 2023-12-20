// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// HelmParameter is a parameter that's passed to helm template during manifest generation
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusOperationStateOperationSyncSourceHelmParameters
    {
        /// <summary>
        /// ForceString determines whether to tell Helm to interpret booleans and numbers as strings
        /// </summary>
        public readonly bool ForceString;
        /// <summary>
        /// Name is the name of the Helm parameter
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Value is the value for the Helm parameter
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private ApplicationStatusOperationStateOperationSyncSourceHelmParameters(
            bool forceString,

            string name,

            string value)
        {
            ForceString = forceString;
            Name = name;
            Value = value;
        }
    }
}
