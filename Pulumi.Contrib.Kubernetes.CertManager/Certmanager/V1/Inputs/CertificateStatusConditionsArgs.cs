// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// CertificateCondition contains condition information for an Certificate.
    /// </summary>
    public class CertificateStatusConditionsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// LastTransitionTime is the timestamp corresponding to the last status change of this condition.
        /// </summary>
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        /// <summary>
        /// Message is a human readable description of the details of the last transition, complementing reason.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// If set, this represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the Certificate.
        /// </summary>
        [Input("observedGeneration")]
        public Input<int>? ObservedGeneration { get; set; }

        /// <summary>
        /// Reason is a brief machine readable explanation for the condition's last transition.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of (`True`, `False`, `Unknown`).
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// Type of the condition, known values are (`Ready`, `Issuing`).
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public CertificateStatusConditionsArgs()
        {
        }
        public static new CertificateStatusConditionsArgs Empty => new CertificateStatusConditionsArgs();
    }
}
