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
    public sealed class ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicy
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyAutomated Automated;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata ManagedNamespaceMetadata;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetry Retry;
        public readonly ImmutableArray<string> SyncOptions;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicy(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyAutomated automated,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata managedNamespaceMetadata,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetry retry,

            ImmutableArray<string> syncOptions)
        {
            Automated = automated;
            ManagedNamespaceMetadata = managedNamespaceMetadata;
            Retry = retry;
            SyncOptions = syncOptions;
        }
    }
}