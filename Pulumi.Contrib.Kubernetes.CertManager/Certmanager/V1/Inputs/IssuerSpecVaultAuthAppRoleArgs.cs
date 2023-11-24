// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// AppRole authenticates with Vault using the App Role auth mechanism, with the role and secret stored in a Kubernetes Secret resource.
    /// </summary>
    public class IssuerSpecVaultAuthAppRoleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Path where the App Role authentication backend is mounted in Vault, e.g: "approle"
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// RoleID configured in the App Role authentication backend when setting up the authentication backend in Vault.
        /// </summary>
        [Input("roleId", required: true)]
        public Input<string> RoleId { get; set; } = null!;

        /// <summary>
        /// Reference to a key in a Secret that contains the App Role secret used to authenticate with Vault. The `key` field must be specified and denotes which entry within the Secret resource is used as the app role secret.
        /// </summary>
        [Input("secretRef", required: true)]
        public Input<IssuerSpecVaultAuthAppRoleSecretRefArgs> SecretRef { get; set; } = null!;

        public IssuerSpecVaultAuthAppRoleArgs()
        {
        }
        public static new IssuerSpecVaultAuthAppRoleArgs Empty => new IssuerSpecVaultAuthAppRoleArgs();
    }
}
