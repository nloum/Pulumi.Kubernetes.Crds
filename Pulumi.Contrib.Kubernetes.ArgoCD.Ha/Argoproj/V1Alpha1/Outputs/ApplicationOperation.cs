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
    /// Operation contains information about a requested or running operation
    /// </summary>
    [OutputType]
    public sealed class ApplicationOperation
    {
        /// <summary>
        /// Info is a list of informational items for this operation
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationInfo> Info;
        /// <summary>
        /// InitiatedBy contains information about who initiated the operations
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationInitiatedBy InitiatedBy;
        /// <summary>
        /// Retry controls the strategy to apply if a sync fails
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationRetry Retry;
        /// <summary>
        /// Sync contains parameters for the operation
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSync Sync;

        [OutputConstructor]
        private ApplicationOperation(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationInfo> info,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationInitiatedBy initiatedBy,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationRetry retry,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSync sync)
        {
            Info = info;
            InitiatedBy = initiatedBy;
            Retry = retry;
            Sync = sync;
        }
    }
}
