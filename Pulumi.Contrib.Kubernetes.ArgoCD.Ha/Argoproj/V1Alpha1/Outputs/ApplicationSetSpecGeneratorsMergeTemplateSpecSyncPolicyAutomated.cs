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
    public sealed class ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyAutomated
    {
        public readonly bool AllowEmpty;
        public readonly bool Prune;
        public readonly bool SelfHeal;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyAutomated(
            bool allowEmpty,

            bool prune,

            bool selfHeal)
        {
            AllowEmpty = allowEmpty;
            Prune = prune;
            SelfHeal = selfHeal;
        }
    }
}
