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
    /// Jsonnet holds options specific to Jsonnet
    /// </summary>
    public class ApplicationStatusHistorySourcesDirectoryJsonnetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extVars")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesDirectoryJsonnetExtVarsArgs>? _extVars;

        /// <summary>
        /// ExtVars is a list of Jsonnet External Variables
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesDirectoryJsonnetExtVarsArgs> ExtVars
        {
            get => _extVars ?? (_extVars = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesDirectoryJsonnetExtVarsArgs>());
            set => _extVars = value;
        }

        [Input("libs")]
        private InputList<string>? _libs;

        /// <summary>
        /// Additional library search dirs
        /// </summary>
        public InputList<string> Libs
        {
            get => _libs ?? (_libs = new InputList<string>());
            set => _libs = value;
        }

        [Input("tlas")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesDirectoryJsonnetTlasArgs>? _tlas;

        /// <summary>
        /// TLAS is a list of Jsonnet Top-level Arguments
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesDirectoryJsonnetTlasArgs> Tlas
        {
            get => _tlas ?? (_tlas = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesDirectoryJsonnetTlasArgs>());
            set => _tlas = value;
        }

        public ApplicationStatusHistorySourcesDirectoryJsonnetArgs()
        {
        }
        public static new ApplicationStatusHistorySourcesDirectoryJsonnetArgs Empty => new ApplicationStatusHistorySourcesDirectoryJsonnetArgs();
    }
}