// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginArgs : global::Pulumi.ResourceArgs
    {
        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginEnvArgs>? _env;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginEnvArgs>());
            set => _env = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginParametersArgs>());
            set => _parameters = value;
        }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginArgs();
    }
}
