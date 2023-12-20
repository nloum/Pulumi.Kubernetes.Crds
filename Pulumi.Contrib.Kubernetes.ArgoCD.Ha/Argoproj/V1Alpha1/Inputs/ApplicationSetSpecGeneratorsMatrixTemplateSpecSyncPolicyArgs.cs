// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("automated")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyAutomatedArgs>? Automated { get; set; }

        [Input("managedNamespaceMetadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyManagedNamespaceMetadataArgs>? ManagedNamespaceMetadata { get; set; }

        [Input("retry")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetryArgs>? Retry { get; set; }

        [Input("syncOptions")]
        private InputList<string>? _syncOptions;
        public InputList<string> SyncOptions
        {
            get => _syncOptions ?? (_syncOptions = new InputList<string>());
            set => _syncOptions = value;
        }

        public ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyArgs Empty => new ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyArgs();
    }
}
