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
    /// SyncResult is the result of a Sync operation
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusOperationStateSyncResult
    {
        /// <summary>
        /// Resources contains a list of sync result items for each individual resource in a sync operation
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultResources> Resources;
        /// <summary>
        /// Revision holds the revision this sync operation was performed to
        /// </summary>
        public readonly string Revision;
        /// <summary>
        /// Revisions holds the revision this sync operation was performed for respective indexed source in sources field
        /// </summary>
        public readonly ImmutableArray<string> Revisions;
        /// <summary>
        /// Source records the application source information of the sync, used for comparing auto-sync
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSource Source;
        /// <summary>
        /// Source records the application source information of the sync, used for comparing auto-sync
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSources> Sources;

        [OutputConstructor]
        private ApplicationStatusOperationStateSyncResult(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultResources> resources,

            string revision,

            ImmutableArray<string> revisions,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSource source,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSources> sources)
        {
            Resources = resources;
            Revision = revision;
            Revisions = revisions;
            Source = source;
            Sources = sources;
        }
    }
}
