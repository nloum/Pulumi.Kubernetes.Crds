// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginArgs : global::Pulumi.ResourceArgs
    {
        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginEnvArgs>? _env;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginEnvArgs>());
            set => _env = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginParametersArgs>());
            set => _parameters = value;
        }

        public ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginArgs Empty => new ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginArgs();
    }
}