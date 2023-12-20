// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabArgs : global::Pulumi.ResourceArgs
    {
        [Input("api")]
        public Input<string>? Api { get; set; }

        [Input("labels")]
        private InputList<string>? _labels;
        public InputList<string> Labels
        {
            get => _labels ?? (_labels = new InputList<string>());
            set => _labels = value;
        }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        [Input("pullRequestState")]
        public Input<string>? PullRequestState { get; set; }

        [Input("tokenRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabTokenRefArgs>? TokenRef { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabArgs();
    }
}
