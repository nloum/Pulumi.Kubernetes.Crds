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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSource
    {
        public readonly string Chart;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectory Directory;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelm Helm;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomize Kustomize;
        public readonly string Path;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePlugin Plugin;
        public readonly string Ref;
        public readonly string RepoURL;
        public readonly string TargetRevision;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSource(
            string chart,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectory directory,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelm helm,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomize kustomize,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePlugin plugin,

            string @ref,

            string repoURL,

            string targetRevision)
        {
            Chart = chart;
            Directory = directory;
            Helm = helm;
            Kustomize = kustomize;
            Path = path;
            Plugin = plugin;
            Ref = @ref;
            RepoURL = repoURL;
            TargetRevision = targetRevision;
        }
    }
}
