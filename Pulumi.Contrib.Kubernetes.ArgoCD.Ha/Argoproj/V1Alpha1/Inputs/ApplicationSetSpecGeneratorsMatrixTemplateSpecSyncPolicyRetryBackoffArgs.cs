// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetryBackoffArgs : global::Pulumi.ResourceArgs
    {
        [Input("duration")]
        public Input<string>? Duration { get; set; }

        [Input("factor")]
        public Input<int>? Factor { get; set; }

        [Input("maxDuration")]
        public Input<string>? MaxDuration { get; set; }

        public ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetryBackoffArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetryBackoffArgs Empty => new ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetryBackoffArgs();
    }
}
