// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmArgs : global::Pulumi.ResourceArgs
    {
        [Input("fileParameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmFileParametersArgs>? _fileParameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmFileParametersArgs> FileParameters
        {
            get => _fileParameters ?? (_fileParameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmFileParametersArgs>());
            set => _fileParameters = value;
        }

        [Input("ignoreMissingValueFiles")]
        public Input<bool>? IgnoreMissingValueFiles { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmParametersArgs>());
            set => _parameters = value;
        }

        [Input("passCredentials")]
        public Input<bool>? PassCredentials { get; set; }

        [Input("releaseName")]
        public Input<string>? ReleaseName { get; set; }

        [Input("skipCrds")]
        public Input<bool>? SkipCrds { get; set; }

        [Input("valueFiles")]
        private InputList<string>? _valueFiles;
        public InputList<string> ValueFiles
        {
            get => _valueFiles ?? (_valueFiles = new InputList<string>());
            set => _valueFiles = value;
        }

        [Input("values")]
        public Input<string>? Values { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmArgs Empty => new ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmArgs();
    }
}
