// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
    /// </summary>
    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
    {
        /// <summary>
        /// key is the label key that the selector applies to.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions(
            string key,

            string @operator,

            ImmutableArray<string> values)
        {
            Key = key;
            Operator = @operator;
            Values = values;
        }
    }
}
