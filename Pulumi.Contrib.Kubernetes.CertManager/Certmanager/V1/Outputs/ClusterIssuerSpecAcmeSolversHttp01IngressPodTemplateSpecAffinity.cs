// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// If specified, the pod's scheduling constraints
    /// </summary>
    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        public readonly ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity NodeAffinity;
        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinity PodAffinity;
        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity(
            ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity nodeAffinity,

            ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinity podAffinity,

            ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
