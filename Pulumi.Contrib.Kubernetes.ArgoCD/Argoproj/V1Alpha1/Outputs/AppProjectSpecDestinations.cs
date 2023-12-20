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
    /// ApplicationDestination holds information about the application's destination
    /// </summary>
    [OutputType]
    public sealed class AppProjectSpecDestinations
    {
        /// <summary>
        /// Name is an alternate way of specifying the target cluster by its symbolic name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Namespace specifies the target namespace for the application's resources. The namespace will only be set for namespace-scoped resources that have not set a value for .metadata.namespace
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Server specifies the URL of the target cluster and must be set to the Kubernetes control plane API
        /// </summary>
        public readonly string Server;

        [OutputConstructor]
        private AppProjectSpecDestinations(
            string name,

            string @namespace,

            string server)
        {
            Name = name;
            Namespace = @namespace;
            Server = server;
        }
    }
}
