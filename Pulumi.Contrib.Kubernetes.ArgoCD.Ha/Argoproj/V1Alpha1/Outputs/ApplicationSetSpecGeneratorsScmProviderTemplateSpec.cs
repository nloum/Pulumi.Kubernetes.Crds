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
    public sealed class ApplicationSetSpecGeneratorsScmProviderTemplateSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecDestination Destination;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecIgnoreDifferences> IgnoreDifferences;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecInfo> Info;
        public readonly string Project;
        public readonly int RevisionHistoryLimit;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSource Source;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSources> Sources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicy SyncPolicy;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsScmProviderTemplateSpec(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecDestination destination,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecIgnoreDifferences> ignoreDifferences,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecInfo> info,

            string project,

            int revisionHistoryLimit,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSource source,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSources> sources,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicy syncPolicy)
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
