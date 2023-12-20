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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicy
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyAutomated Automated;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata ManagedNamespaceMetadata;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyRetry Retry;
        public readonly ImmutableArray<string> SyncOptions;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicy(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyAutomated automated,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata managedNamespaceMetadata,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyRetry retry,

            ImmutableArray<string> syncOptions)
        {
            Automated = automated;
            ManagedNamespaceMetadata = managedNamespaceMetadata;
            Retry = retry;
            SyncOptions = syncOptions;
        }
    }
}