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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlab
    {
        public readonly string Api;
        public readonly bool Insecure;
        public readonly ImmutableArray<string> Labels;
        public readonly string Project;
        public readonly string PullRequestState;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabTokenRef TokenRef;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlab(
            string api,

            bool insecure,

            ImmutableArray<string> labels,

            string project,

            string pullRequestState,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabTokenRef tokenRef)
        {
            Api = api;
            Insecure = insecure;
            Labels = labels;
            Project = project;
            PullRequestState = pullRequestState;
            TokenRef = tokenRef;
        }
    }
}