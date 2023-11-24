// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// SelfSigned configures this issuer to 'self sign' certificates using the private key used to create the CertificateRequest object.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecSelfSigned
    {
        /// <summary>
        /// The CRL distribution points is an X.509 v3 certificate extension which identifies the location of the CRL from which the revocation of this certificate can be checked. If not set certificate will be issued without CDP. Values are strings.
        /// </summary>
        public readonly ImmutableArray<string> CrlDistributionPoints;

        [OutputConstructor]
        private IssuerSpecSelfSigned(ImmutableArray<string> crlDistributionPoints)
        {
            CrlDistributionPoints = crlDistributionPoints;
        }
    }
}
