// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// The required Secret field containing a Kubernetes ServiceAccount JWT used for authenticating with Vault. Use of 'ambient credentials' is not supported.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecVaultAuthKubernetesSecretRef
    {
        /// <summary>
        /// The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private IssuerSpecVaultAuthKubernetesSecretRef(
            string key,

            string name)
        {
            Key = key;
            Name = name;
        }
    }
}
