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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars> ExtVars;
        public readonly ImmutableArray<string> Libs;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas> Tlas;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars> extVars,

            ImmutableArray<string> libs,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas> tlas)
        {
            ExtVars = extVars;
            Libs = libs;
            Tlas = tlas;
        }
    }
}