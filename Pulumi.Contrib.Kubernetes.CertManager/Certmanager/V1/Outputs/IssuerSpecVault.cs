// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// Vault configures this issuer to sign certificates using a HashiCorp Vault PKI backend.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecVault
    {
        /// <summary>
        /// Auth configures how cert-manager authenticates with the Vault server.
        /// </summary>
        public readonly IssuerSpecVaultAuth Auth;
        /// <summary>
        /// Base64-encoded bundle of PEM CAs which will be used to validate the certificate chain presented by Vault. Only used if using HTTPS to connect to Vault and ignored for HTTP connections. Mutually exclusive with CABundleSecretRef. If neither CABundle nor CABundleSecretRef are defined, the certificate bundle in the cert-manager controller container is used to validate the TLS connection.
        /// </summary>
        public readonly string CaBundle;
        /// <summary>
        /// Reference to a Secret containing a bundle of PEM-encoded CAs to use when verifying the certificate chain presented by Vault when using HTTPS. Mutually exclusive with CABundle. If neither CABundle nor CABundleSecretRef are defined, the certificate bundle in the cert-manager controller container is used to validate the TLS connection. If no key for the Secret is specified, cert-manager will default to 'ca.crt'.
        /// </summary>
        public readonly IssuerSpecVaultCaBundleSecretRef CaBundleSecretRef;
        /// <summary>
        /// Name of the vault namespace. Namespaces is a set of features within Vault Enterprise that allows Vault environments to support Secure Multi-tenancy. e.g: "ns1" More about namespaces can be found here https://www.vaultproject.io/docs/enterprise/namespaces
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Path is the mount path of the Vault PKI backend's `sign` endpoint, e.g: "my_pki_mount/sign/my-role-name".
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Server is the connection address for the Vault server, e.g: "https://vault.example.com:8200".
        /// </summary>
        public readonly string Server;

        [OutputConstructor]
        private IssuerSpecVault(
            IssuerSpecVaultAuth auth,

            string caBundle,

            IssuerSpecVaultCaBundleSecretRef caBundleSecretRef,

            string @namespace,

            string path,

            string server)
        {
            Auth = auth;
            CaBundle = caBundle;
            CaBundleSecretRef = caBundleSecretRef;
            Namespace = @namespace;
            Path = path;
            Server = server;
        }
    }
}
