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
    /// HealthStatus contains information about the currently observed health state of an application or resource
    /// </summary>
    public class ApplicationStatusResourcesHealthArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Message is a human-readable informational message describing the health status
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// Status holds the status code of the application or resource
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public ApplicationStatusResourcesHealthArgs()
        {
        }
        public static new ApplicationStatusResourcesHealthArgs Empty => new ApplicationStatusResourcesHealthArgs();
    }
}
