// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateArgs : global::Pulumi.ResourceArgs
    {
        [Input("metadata", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateMetadataArgs> Metadata { get; set; } = null!;

        [Input("spec", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecArgs> Spec { get; set; } = null!;

        public ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateArgs();
    }
}
