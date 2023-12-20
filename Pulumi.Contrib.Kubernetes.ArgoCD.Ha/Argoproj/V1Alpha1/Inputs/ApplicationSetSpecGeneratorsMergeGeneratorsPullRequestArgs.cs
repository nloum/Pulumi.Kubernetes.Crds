// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestArgs : global::Pulumi.ResourceArgs
    {
        [Input("bitbucketServer")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketServerArgs>? BitbucketServer { get; set; }

        [Input("filters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestFiltersArgs>? _filters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestFiltersArgs>());
            set => _filters = value;
        }

        [Input("gitea")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaArgs>? Gitea { get; set; }

        [Input("github")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGithubArgs>? Github { get; set; }

        [Input("gitlab")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGitlabArgs>? Gitlab { get; set; }

        [Input("requeueAfterSeconds")]
        public Input<int>? RequeueAfterSeconds { get; set; }

        [Input("template")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateArgs>? Template { get; set; }

        public ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestArgs Empty => new ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestArgs();
    }
}
