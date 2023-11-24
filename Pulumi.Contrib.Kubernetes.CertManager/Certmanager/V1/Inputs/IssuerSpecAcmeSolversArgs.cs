// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// An ACMEChallengeSolver describes how to solve ACME challenges for the issuer it is part of. A selector may be provided to use different solving strategies for different DNS names. Only one of HTTP01 or DNS01 must be provided.
    /// </summary>
    public class IssuerSpecAcmeSolversArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configures cert-manager to attempt to complete authorizations by performing the DNS01 challenge flow.
        /// </summary>
        [Input("dns01")]
        public Input<IssuerSpecAcmeSolversDns01Args>? Dns01 { get; set; }

        /// <summary>
        /// Configures cert-manager to attempt to complete authorizations by performing the HTTP01 challenge flow. It is not possible to obtain certificates for wildcard domain names (e.g. `*.example.com`) using the HTTP01 challenge mechanism.
        /// </summary>
        [Input("http01")]
        public Input<IssuerSpecAcmeSolversHttp01Args>? Http01 { get; set; }

        /// <summary>
        /// Selector selects a set of DNSNames on the Certificate resource that should be solved using this challenge solver. If not specified, the solver will be treated as the 'default' solver with the lowest priority, i.e. if any other solver has a more specific match, it will be used instead.
        /// </summary>
        [Input("selector")]
        public Input<IssuerSpecAcmeSolversSelectorArgs>? Selector { get; set; }

        public IssuerSpecAcmeSolversArgs()
        {
        }
        public static new IssuerSpecAcmeSolversArgs Empty => new IssuerSpecAcmeSolversArgs();
    }
}
