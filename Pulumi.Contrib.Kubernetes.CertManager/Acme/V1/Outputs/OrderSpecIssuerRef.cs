// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Outputs
{

    /// <summary>
    /// IssuerRef references a properly configured ACME-type Issuer which should be used to create this Order. If the Issuer does not exist, processing will be retried. If the Issuer is not an 'ACME' Issuer, an error will be returned and the Order will be marked as failed.
    /// </summary>
    [OutputType]
    public sealed class OrderSpecIssuerRef
    {
        /// <summary>
        /// Group of the resource being referred to.
        /// </summary>
        public readonly string Group;
        /// <summary>
        /// Kind of the resource being referred to.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the resource being referred to.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private OrderSpecIssuerRef(
            string group,

            string kind,

            string name)
        {
            Group = group;
            Kind = kind;
            Name = name;
        }
    }
}
