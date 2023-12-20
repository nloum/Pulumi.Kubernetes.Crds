// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Helm holds helm specific options
    /// </summary>
    public class ApplicationStatusHistorySourcesHelmArgs : global::Pulumi.ResourceArgs
    {
        [Input("fileParameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesHelmFileParametersArgs>? _fileParameters;

        /// <summary>
        /// FileParameters are file parameters to the helm template
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesHelmFileParametersArgs> FileParameters
        {
            get => _fileParameters ?? (_fileParameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesHelmFileParametersArgs>());
            set => _fileParameters = value;
        }

        /// <summary>
        /// IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values
        /// </summary>
        [Input("ignoreMissingValueFiles")]
        public Input<bool>? IgnoreMissingValueFiles { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesHelmParametersArgs>? _parameters;

        /// <summary>
        /// Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesHelmParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesHelmParametersArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// PassCredentials pass credentials to all domains (Helm's --pass-credentials)
        /// </summary>
        [Input("passCredentials")]
        public Input<bool>? PassCredentials { get; set; }

        /// <summary>
        /// ReleaseName is the Helm release name to use. If omitted it will use the application name
        /// </summary>
        [Input("releaseName")]
        public Input<string>? ReleaseName { get; set; }

        /// <summary>
        /// SkipCrds skips custom resource definition installation step (Helm's --skip-crds)
        /// </summary>
        [Input("skipCrds")]
        public Input<bool>? SkipCrds { get; set; }

        [Input("valueFiles")]
        private InputList<string>? _valueFiles;

        /// <summary>
        /// ValuesFiles is a list of Helm value files to use when generating a template
        /// </summary>
        public InputList<string> ValueFiles
        {
            get => _valueFiles ?? (_valueFiles = new InputList<string>());
            set => _valueFiles = value;
        }

        /// <summary>
        /// Values specifies Helm values to be passed to helm template, typically defined as a block
        /// </summary>
        [Input("values")]
        public Input<string>? Values { get; set; }

        /// <summary>
        /// Version is the Helm version to use for templating ("3")
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationStatusHistorySourcesHelmArgs()
        {
        }
        public static new ApplicationStatusHistorySourcesHelmArgs Empty => new ApplicationStatusHistorySourcesHelmArgs();
    }
}
