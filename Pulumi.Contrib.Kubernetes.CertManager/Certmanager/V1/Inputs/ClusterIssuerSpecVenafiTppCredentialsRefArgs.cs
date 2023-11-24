// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// CredentialsRef is a reference to a Secret containing the username and password for the TPP server. The secret must contain two keys, 'username' and 'password'.
    /// </summary>
    public class ClusterIssuerSpecVenafiTppCredentialsRefArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ClusterIssuerSpecVenafiTppCredentialsRefArgs()
        {
        }
        public static new ClusterIssuerSpecVenafiTppCredentialsRefArgs Empty => new ClusterIssuerSpecVenafiTppCredentialsRefArgs();
    }
}
