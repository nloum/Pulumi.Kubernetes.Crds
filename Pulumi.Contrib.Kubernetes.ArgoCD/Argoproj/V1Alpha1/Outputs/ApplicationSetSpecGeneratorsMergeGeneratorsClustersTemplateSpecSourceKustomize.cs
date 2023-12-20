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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomize
    {
        public readonly ImmutableDictionary<string, string> CommonAnnotations;
        public readonly bool CommonAnnotationsEnvsubst;
        public readonly ImmutableDictionary<string, string> CommonLabels;
        public readonly bool ForceCommonAnnotations;
        public readonly bool ForceCommonLabels;
        public readonly ImmutableArray<string> Images;
        public readonly string NamePrefix;
        public readonly string NameSuffix;
        public readonly string Namespace;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizeReplicas> Replicas;
        public readonly string Version;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomize(
            ImmutableDictionary<string, string> commonAnnotations,

            bool commonAnnotationsEnvsubst,

            ImmutableDictionary<string, string> commonLabels,

            bool forceCommonAnnotations,

            bool forceCommonLabels,

            ImmutableArray<string> images,

            string namePrefix,

            string nameSuffix,

            string @namespace,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizeReplicas> replicas,

            string version)
        {
            CommonAnnotations = commonAnnotations;
            CommonAnnotationsEnvsubst = commonAnnotationsEnvsubst;
            CommonLabels = commonLabels;
            ForceCommonAnnotations = forceCommonAnnotations;
            ForceCommonLabels = forceCommonLabels;
            Images = images;
            NamePrefix = namePrefix;
            NameSuffix = nameSuffix;
            Namespace = @namespace;
            Replicas = replicas;
            Version = version;
        }
    }
}
