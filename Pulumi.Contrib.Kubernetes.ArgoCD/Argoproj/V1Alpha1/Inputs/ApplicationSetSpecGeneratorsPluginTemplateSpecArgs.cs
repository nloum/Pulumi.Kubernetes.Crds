// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsPluginTemplateSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("destination", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecDestinationArgs> Destination { get; set; } = null!;

        [Input("ignoreDifferences")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecIgnoreDifferencesArgs>? _ignoreDifferences;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecIgnoreDifferencesArgs> IgnoreDifferences
        {
            get => _ignoreDifferences ?? (_ignoreDifferences = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecIgnoreDifferencesArgs>());
            set => _ignoreDifferences = value;
        }

        [Input("info")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecInfoArgs>? _info;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecInfoArgs> Info
        {
            get => _info ?? (_info = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecInfoArgs>());
            set => _info = value;
        }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        [Input("revisionHistoryLimit")]
        public Input<int>? RevisionHistoryLimit { get; set; }

        [Input("source")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourceArgs>? Source { get; set; }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesArgs>? _sources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesArgs>());
            set => _sources = value;
        }

        [Input("syncPolicy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyArgs>? SyncPolicy { get; set; }

        public ApplicationSetSpecGeneratorsPluginTemplateSpecArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsPluginTemplateSpecArgs Empty => new ApplicationSetSpecGeneratorsPluginTemplateSpecArgs();
    }
}