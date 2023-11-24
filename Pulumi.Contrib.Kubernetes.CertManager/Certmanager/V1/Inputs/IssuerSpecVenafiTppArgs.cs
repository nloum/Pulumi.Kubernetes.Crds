// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// TPP specifies Trust Protection Platform configuration settings. Only one of TPP or Cloud may be specified.
    /// </summary>
    public class IssuerSpecVenafiTppArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Base64-encoded bundle of PEM CAs which will be used to validate the certificate chain presented by the TPP server. Only used if using HTTPS; ignored for HTTP. If undefined, the certificate bundle in the cert-manager controller container is used to validate the chain.
        /// </summary>
        [Input("caBundle")]
        public Input<string>? CaBundle { get; set; }

        /// <summary>
        /// CredentialsRef is a reference to a Secret containing the username and password for the TPP server. The secret must contain two keys, 'username' and 'password'.
        /// </summary>
        [Input("credentialsRef", required: true)]
        public Input<IssuerSpecVenafiTppCredentialsRefArgs> CredentialsRef { get; set; } = null!;

        /// <summary>
        /// URL is the base URL for the vedsdk endpoint of the Venafi TPP instance, for example: "https://tpp.example.com/vedsdk".
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public IssuerSpecVenafiTppArgs()
        {
        }
        public static new IssuerSpecVenafiTppArgs Empty => new IssuerSpecVenafiTppArgs();
    }
}
