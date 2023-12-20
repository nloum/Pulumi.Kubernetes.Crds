// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecDestination Destination;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences> IgnoreDifferences;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecInfo> Info;
        public readonly string Project;
        public readonly int RevisionHistoryLimit;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSource Source;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSources> Sources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy SyncPolicy;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpec(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecDestination destination,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences> ignoreDifferences,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecInfo> info,

            string project,

            int revisionHistoryLimit,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSource source,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSources> sources,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy syncPolicy)
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
