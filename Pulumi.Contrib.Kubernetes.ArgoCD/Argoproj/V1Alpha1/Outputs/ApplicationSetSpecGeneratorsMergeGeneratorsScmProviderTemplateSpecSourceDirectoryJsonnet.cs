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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars> ExtVars;
        public readonly ImmutableArray<string> Libs;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas> Tlas;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars> extVars,

            ImmutableArray<string> libs,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas> tlas)
        {
            ExtVars = extVars;
            Libs = libs;
            Tlas = tlas;
        }
    }
}