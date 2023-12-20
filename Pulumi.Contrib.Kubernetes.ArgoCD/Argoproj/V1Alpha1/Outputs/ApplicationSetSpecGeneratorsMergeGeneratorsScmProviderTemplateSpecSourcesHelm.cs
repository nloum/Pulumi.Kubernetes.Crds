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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelm
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters> FileParameters;
        public readonly bool IgnoreMissingValueFiles;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmParameters> Parameters;
        public readonly bool PassCredentials;
        public readonly string ReleaseName;
        public readonly bool SkipCrds;
        public readonly ImmutableArray<string> ValueFiles;
        public readonly string Values;
        public readonly string Version;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelm(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters> fileParameters,

            bool ignoreMissingValueFiles,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmParameters> parameters,

            bool passCredentials,

            string releaseName,

            bool skipCrds,

            ImmutableArray<string> valueFiles,

            string values,

            string version)
        {
            FileParameters = fileParameters;
            IgnoreMissingValueFiles = ignoreMissingValueFiles;
            Parameters = parameters;
            PassCredentials = passCredentials;
            ReleaseName = releaseName;
            SkipCrds = skipCrds;
            ValueFiles = valueFiles;
            Values = values;
            Version = version;
        }
    }
}
