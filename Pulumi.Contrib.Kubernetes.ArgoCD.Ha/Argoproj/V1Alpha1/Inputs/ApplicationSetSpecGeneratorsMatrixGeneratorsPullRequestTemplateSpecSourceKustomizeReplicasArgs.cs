// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizeReplicasArgs : global::Pulumi.ResourceArgs
    {
        [Input("count", required: true)]
        public InputUnion<int, string> Count { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizeReplicasArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizeReplicasArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizeReplicasArgs();
    }
}
