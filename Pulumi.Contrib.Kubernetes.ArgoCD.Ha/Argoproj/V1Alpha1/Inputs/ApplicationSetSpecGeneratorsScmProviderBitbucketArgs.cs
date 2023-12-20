// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsScmProviderBitbucketArgs : global::Pulumi.ResourceArgs
    {
        [Input("allBranches")]
        public Input<bool>? AllBranches { get; set; }

        [Input("appPasswordRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderBitbucketAppPasswordRefArgs> AppPasswordRef { get; set; } = null!;

        [Input("owner", required: true)]
        public Input<string> Owner { get; set; } = null!;

        [Input("user", required: true)]
        public Input<string> User { get; set; } = null!;

        public ApplicationSetSpecGeneratorsScmProviderBitbucketArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsScmProviderBitbucketArgs Empty => new ApplicationSetSpecGeneratorsScmProviderBitbucketArgs();
    }
}
