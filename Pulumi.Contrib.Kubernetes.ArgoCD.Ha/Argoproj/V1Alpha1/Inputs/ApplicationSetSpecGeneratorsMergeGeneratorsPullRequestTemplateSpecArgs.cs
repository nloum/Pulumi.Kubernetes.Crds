// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("destination", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecDestinationArgs> Destination { get; set; } = null!;

        [Input("ignoreDifferences")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecIgnoreDifferencesArgs>? _ignoreDifferences;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecIgnoreDifferencesArgs> IgnoreDifferences
        {
            get => _ignoreDifferences ?? (_ignoreDifferences = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecIgnoreDifferencesArgs>());
            set => _ignoreDifferences = value;
        }

        [Input("info")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecInfoArgs>? _info;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecInfoArgs> Info
        {
            get => _info ?? (_info = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecInfoArgs>());
            set => _info = value;
        }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        [Input("revisionHistoryLimit")]
        public Input<int>? RevisionHistoryLimit { get; set; }

        [Input("source")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceArgs>? Source { get; set; }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesArgs>? _sources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesArgs>());
            set => _sources = value;
        }

        [Input("syncPolicy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyArgs>? SyncPolicy { get; set; }

        public ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecArgs Empty => new ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecArgs();
    }
}