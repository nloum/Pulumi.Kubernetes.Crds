// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Use the Google Cloud DNS API to manage DNS01 challenge records.
    /// </summary>
    public class ClusterIssuerSpecAcmeSolversDns01CloudDNSArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// HostedZoneName is an optional field that tells cert-manager in which Cloud DNS zone the challenge record has to be created. If left empty cert-manager will automatically choose a zone.
        /// </summary>
        [Input("hostedZoneName")]
        public Input<string>? HostedZoneName { get; set; }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("serviceAccountSecretRef")]
        public Input<ClusterIssuerSpecAcmeSolversDns01CloudDNSServiceAccountSecretRefArgs>? ServiceAccountSecretRef { get; set; }

        public ClusterIssuerSpecAcmeSolversDns01CloudDNSArgs()
        {
        }
        public static new ClusterIssuerSpecAcmeSolversDns01CloudDNSArgs Empty => new ClusterIssuerSpecAcmeSolversDns01CloudDNSArgs();
    }
}
