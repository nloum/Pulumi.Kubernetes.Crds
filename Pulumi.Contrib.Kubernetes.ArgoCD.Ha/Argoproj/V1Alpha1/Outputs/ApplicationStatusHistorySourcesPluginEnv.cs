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
    /// EnvEntry represents an entry in the application's environment
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusHistorySourcesPluginEnv
    {
        /// <summary>
        /// Name is the name of the variable, usually expressed in uppercase
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Value is the value of the variable
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private ApplicationStatusHistorySourcesPluginEnv(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
