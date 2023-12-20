// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("automated")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyAutomatedArgs>? Automated { get; set; }

        [Input("managedNamespaceMetadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyManagedNamespaceMetadataArgs>? ManagedNamespaceMetadata { get; set; }

        [Input("retry")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyRetryArgs>? Retry { get; set; }

        [Input("syncOptions")]
        private InputList<string>? _syncOptions;
        public InputList<string> SyncOptions
        {
            get => _syncOptions ?? (_syncOptions = new InputList<string>());
            set => _syncOptions = value;
        }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyArgs();
    }
}
