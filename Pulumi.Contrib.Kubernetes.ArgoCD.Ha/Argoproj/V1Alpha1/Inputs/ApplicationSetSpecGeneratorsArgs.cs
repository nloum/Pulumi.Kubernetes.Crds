// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterDecisionResource")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceArgs>? ClusterDecisionResource { get; set; }

        [Input("clusters")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClustersArgs>? Clusters { get; set; }

        [Input("git")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitArgs>? Git { get; set; }

        [Input("list")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsListArgs>? List { get; set; }

        [Input("matrix")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixArgs>? Matrix { get; set; }

        [Input("merge")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeArgs>? Merge { get; set; }

        [Input("pullRequest")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPullRequestArgs>? PullRequest { get; set; }

        [Input("scmProvider")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderArgs>? ScmProvider { get; set; }

        [Input("selector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsSelectorArgs>? Selector { get; set; }

        public ApplicationSetSpecGeneratorsArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsArgs Empty => new ApplicationSetSpecGeneratorsArgs();
    }
}
