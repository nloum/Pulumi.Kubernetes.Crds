// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabArgs : global::Pulumi.ResourceArgs
    {
        [Input("allBranches")]
        public Input<bool>? AllBranches { get; set; }

        [Input("api")]
        public Input<string>? Api { get; set; }

        [Input("group", required: true)]
        public Input<string> Group { get; set; } = null!;

        [Input("includeSubgroups")]
        public Input<bool>? IncludeSubgroups { get; set; }

        [Input("tokenRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabTokenRefArgs>? TokenRef { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabArgs();
    }
}