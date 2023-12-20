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
    /// ComparedTo contains information about what has been compared
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusSyncComparedTo
    {
        /// <summary>
        /// Destination is a reference to the application's destination used for comparison
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToDestination Destination;
        /// <summary>
        /// Source is a reference to the application's source used for comparison
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSource Source;
        /// <summary>
        /// Sources is a reference to the application's multiple sources used for comparison
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSources> Sources;

        [OutputConstructor]
        private ApplicationStatusSyncComparedTo(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToDestination destination,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSource source,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSources> sources)
        {
            Destination = destination;
            Source = source;
            Sources = sources;
        }
    }
}
