// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecStrategyArgs : global::Pulumi.ResourceArgs
    {
        [Input("rollingSync")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecStrategyRollingSyncArgs>? RollingSync { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public ApplicationSetSpecStrategyArgs()
        {
        }
        public static new ApplicationSetSpecStrategyArgs Empty => new ApplicationSetSpecStrategyArgs();
    }
}
