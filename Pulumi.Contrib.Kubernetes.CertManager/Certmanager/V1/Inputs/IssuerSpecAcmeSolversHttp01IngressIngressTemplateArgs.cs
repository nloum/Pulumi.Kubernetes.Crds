// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Optional ingress template used to configure the ACME challenge solver ingress used for HTTP01 challenges.
    /// </summary>
    public class IssuerSpecAcmeSolversHttp01IngressIngressTemplateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.
        /// </summary>
        [Input("metadata")]
        public Input<IssuerSpecAcmeSolversHttp01IngressIngressTemplateMetadataArgs>? Metadata { get; set; }

        public IssuerSpecAcmeSolversHttp01IngressIngressTemplateArgs()
        {
        }
        public static new IssuerSpecAcmeSolversHttp01IngressIngressTemplateArgs Empty => new IssuerSpecAcmeSolversHttp01IngressIngressTemplateArgs();
    }
}
