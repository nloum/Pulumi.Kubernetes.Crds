// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationStatusOperationStateSyncResultSourcePluginParameters
    {
        /// <summary>
        /// Array is the value of an array type parameter.
        /// </summary>
        public readonly ImmutableArray<string> Array;
        /// <summary>
        /// Map is the value of a map type parameter.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Map;
        /// <summary>
        /// Name is the name identifying a parameter.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// String_ is the value of a string type parameter.
        /// </summary>
        public readonly string String;

        [OutputConstructor]
        private ApplicationStatusOperationStateSyncResultSourcePluginParameters(
            ImmutableArray<string> array,

            ImmutableDictionary<string, string> map,

            string name,

            string @string)
        {
            Array = array;
            Map = map;
            Name = name;
            String = @string;
        }
    }
}
