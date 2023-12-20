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
    /// ApplicationSpec represents desired application state. Contains link to repository with application definition and additional parameters link definition revision.
    /// </summary>
    [OutputType]
    public sealed class ApplicationSpec
    {
        /// <summary>
        /// Destination is a reference to the target Kubernetes server and namespace
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecDestination Destination;
        /// <summary>
        /// IgnoreDifferences is a list of resources and their fields which should be ignored during comparison
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecIgnoreDifferences> IgnoreDifferences;
        /// <summary>
        /// Info contains a list of information (URLs, email addresses, and plain text) that relates to the application
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecInfo> Info;
        /// <summary>
        /// Project is a reference to the project this application belongs to. The empty string means that application belongs to the 'default' project.
        /// </summary>
        public readonly string Project;
        /// <summary>
        /// RevisionHistoryLimit limits the number of items kept in the application's revision history, which is used for informational purposes as well as for rollbacks to previous versions. This should only be changed in exceptional circumstances. Setting to zero will store no history. This will reduce storage used. Increasing will increase the space used to store the history, so we do not recommend increasing it. Default is 10.
        /// </summary>
        public readonly int RevisionHistoryLimit;
        /// <summary>
        /// Source is a reference to the location of the application's manifests or chart
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSource Source;
        /// <summary>
        /// Sources is a reference to the location of the application's manifests or chart
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSources> Sources;
        /// <summary>
        /// SyncPolicy controls when and how a sync will be performed
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicy SyncPolicy;

        [OutputConstructor]
        private ApplicationSpec(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecDestination destination,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecIgnoreDifferences> ignoreDifferences,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecInfo> info,

            string project,

            int revisionHistoryLimit,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSource source,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSources> sources,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicy syncPolicy)
        {
            Destination = destination;
            IgnoreDifferences = ignoreDifferences;
            Info = info;
            Project = project;
            RevisionHistoryLimit = revisionHistoryLimit;
            Source = source;
            Sources = sources;
            SyncPolicy = syncPolicy;
        }
    }
}