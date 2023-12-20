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
    /// EnvEntry represents an entry in the application's environment
    /// </summary>
    public class ApplicationOperationSyncSourcePluginEnvArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name is the name of the variable, usually expressed in uppercase
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Value is the value of the variable
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public ApplicationOperationSyncSourcePluginEnvArgs()
        {
        }
        public static new ApplicationOperationSyncSourcePluginEnvArgs Empty => new ApplicationOperationSyncSourcePluginEnvArgs();
    }
}
