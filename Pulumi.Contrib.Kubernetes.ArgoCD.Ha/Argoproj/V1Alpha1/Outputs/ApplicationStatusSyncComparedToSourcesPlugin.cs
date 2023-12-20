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
    /// Plugin holds config management plugin specific options
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusSyncComparedToSourcesPlugin
    {
        /// <summary>
        /// Env is a list of environment variable entries
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesPluginEnv> Env;
        public readonly string Name;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesPluginParameters> Parameters;

        [OutputConstructor]
        private ApplicationStatusSyncComparedToSourcesPlugin(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesPluginEnv> env,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesPluginParameters> parameters)
        {
            Env = env;
            Name = name;
            Parameters = parameters;
        }
    }
}
