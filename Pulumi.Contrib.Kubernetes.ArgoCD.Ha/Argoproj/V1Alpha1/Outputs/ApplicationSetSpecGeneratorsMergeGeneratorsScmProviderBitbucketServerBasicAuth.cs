// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuth
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef PasswordRef;
        public readonly string Username;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuth(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef passwordRef,

            string username)
        {
            PasswordRef = passwordRef;
            Username = username;
        }
    }
}