// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// Auth configures how cert-manager authenticates with the Vault server.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecVaultAuth
    {
        /// <summary>
        /// AppRole authenticates with Vault using the App Role auth mechanism, with the role and secret stored in a Kubernetes Secret resource.
        /// </summary>
        public readonly IssuerSpecVaultAuthAppRole AppRole;
        /// <summary>
        /// Kubernetes authenticates with Vault by passing the ServiceAccount token stored in the named Secret resource to the Vault server.
        /// </summary>
        public readonly IssuerSpecVaultAuthKubernetes Kubernetes;
        /// <summary>
        /// TokenSecretRef authenticates with Vault by presenting a token.
        /// </summary>
        public readonly IssuerSpecVaultAuthTokenSecretRef TokenSecretRef;

        [OutputConstructor]
        private IssuerSpecVaultAuth(
            IssuerSpecVaultAuthAppRole appRole,

            IssuerSpecVaultAuthKubernetes kubernetes,

            IssuerSpecVaultAuthTokenSecretRef tokenSecretRef)
        {
            AppRole = appRole;
            Kubernetes = kubernetes;
            TokenSecretRef = tokenSecretRef;
        }
    }
}
