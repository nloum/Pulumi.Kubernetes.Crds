// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecStrategyRollingSyncStepsArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecStrategyRollingSyncStepsMatchExpressionsArgs>? _matchExpressions;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecStrategyRollingSyncStepsMatchExpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecStrategyRollingSyncStepsMatchExpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("maxUpdate")]
        public InputUnion<int, string>? MaxUpdate { get; set; }

        public ApplicationSetSpecStrategyRollingSyncStepsArgs()
        {
        }
        public static new ApplicationSetSpecStrategyRollingSyncStepsArgs Empty => new ApplicationSetSpecStrategyRollingSyncStepsArgs();
    }
}
