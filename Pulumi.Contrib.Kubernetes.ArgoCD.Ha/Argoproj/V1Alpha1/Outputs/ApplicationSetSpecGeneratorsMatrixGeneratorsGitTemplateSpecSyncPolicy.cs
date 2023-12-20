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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicy
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyAutomated Automated;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata ManagedNamespaceMetadata;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyRetry Retry;
        public readonly ImmutableArray<string> SyncOptions;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicy(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyAutomated automated,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata managedNamespaceMetadata,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyRetry retry,

            ImmutableArray<string> syncOptions)
        {
            Automated = automated;
            ManagedNamespaceMetadata = managedNamespaceMetadata;
            Retry = retry;
            SyncOptions = syncOptions;
        }
    }
}
