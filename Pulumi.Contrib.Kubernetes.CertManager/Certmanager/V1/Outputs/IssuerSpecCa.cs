// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// CA configures this issuer to sign certificates using a signing CA keypair stored in a Secret resource. This is used to build internal PKIs that are managed by cert-manager.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecCa
    {
        /// <summary>
        /// The CRL distribution points is an X.509 v3 certificate extension which identifies the location of the CRL from which the revocation of this certificate can be checked. If not set, certificates will be issued without distribution points set.
        /// </summary>
        public readonly ImmutableArray<string> CrlDistributionPoints;
        /// <summary>
        /// The OCSP server list is an X.509 v3 extension that defines a list of URLs of OCSP responders. The OCSP responders can be queried for the revocation status of an issued certificate. If not set, the certificate will be issued with no OCSP servers set. For example, an OCSP server URL could be "http://ocsp.int-x3.letsencrypt.org".
        /// </summary>
        public readonly ImmutableArray<string> OcspServers;
        /// <summary>
        /// SecretName is the name of the secret used to sign Certificates issued by this Issuer.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private IssuerSpecCa(
            ImmutableArray<string> crlDistributionPoints,

            ImmutableArray<string> ocspServers,

            string secretName)
        {
            CrlDistributionPoints = crlDistributionPoints;
            OcspServers = ocspServers;
            SecretName = secretName;
        }
    }
}
