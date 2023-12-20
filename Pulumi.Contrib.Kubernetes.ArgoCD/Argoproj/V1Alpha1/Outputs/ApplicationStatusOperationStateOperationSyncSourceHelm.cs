// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Helm holds helm specific options
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusOperationStateOperationSyncSourceHelm
    {
        /// <summary>
        /// FileParameters are file parameters to the helm template
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceHelmFileParameters> FileParameters;
        /// <summary>
        /// IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values
        /// </summary>
        public readonly bool IgnoreMissingValueFiles;
        /// <summary>
        /// Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceHelmParameters> Parameters;
        /// <summary>
        /// PassCredentials pass credentials to all domains (Helm's --pass-credentials)
        /// </summary>
        public readonly bool PassCredentials;
        /// <summary>
        /// ReleaseName is the Helm release name to use. If omitted it will use the application name
        /// </summary>
        public readonly string ReleaseName;
        /// <summary>
        /// SkipCrds skips custom resource definition installation step (Helm's --skip-crds)
        /// </summary>
        public readonly bool SkipCrds;
        /// <summary>
        /// ValuesFiles is a list of Helm value files to use when generating a template
        /// </summary>
        public readonly ImmutableArray<string> ValueFiles;
        /// <summary>
        /// Values specifies Helm values to be passed to helm template, typically defined as a block
        /// </summary>
        public readonly string Values;
        /// <summary>
        /// Version is the Helm version to use for templating ("3")
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApplicationStatusOperationStateOperationSyncSourceHelm(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceHelmFileParameters> fileParameters,

            bool ignoreMissingValueFiles,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceHelmParameters> parameters,

            bool passCredentials,

            string releaseName,

            bool skipCrds,

            ImmutableArray<string> valueFiles,

            string values,

            string version)
        {
            FileParameters = fileParameters;
            IgnoreMissingValueFiles = ignoreMissingValueFiles;
            Parameters = parameters;
            PassCredentials = passCredentials;
            ReleaseName = releaseName;
            SkipCrds = skipCrds;
            ValueFiles = valueFiles;
            Values = values;
            Version = version;
        }
    }
}
