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
    public sealed class ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelm
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmFileParameters> FileParameters;
        public readonly bool IgnoreMissingValueFiles;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmParameters> Parameters;
        public readonly bool PassCredentials;
        public readonly string ReleaseName;
        public readonly bool SkipCrds;
        public readonly ImmutableArray<string> ValueFiles;
        public readonly string Values;
        public readonly ImmutableDictionary<string, object> ValuesObject;
        public readonly string Version;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelm(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmFileParameters> fileParameters,

            bool ignoreMissingValueFiles,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmParameters> parameters,

            bool passCredentials,

            string releaseName,

            bool skipCrds,

            ImmutableArray<string> valueFiles,

            string values,

            ImmutableDictionary<string, object> valuesObject,

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
            ValuesObject = valuesObject;
            Version = version;
        }
    }
}