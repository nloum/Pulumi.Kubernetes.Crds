// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecTemplateSpecSourceKustomizeArgs : global::Pulumi.ResourceArgs
    {
        [Input("commonAnnotations")]
        private InputMap<string>? _commonAnnotations;
        public InputMap<string> CommonAnnotations
        {
            get => _commonAnnotations ?? (_commonAnnotations = new InputMap<string>());
            set => _commonAnnotations = value;
        }

        [Input("commonAnnotationsEnvsubst")]
        public Input<bool>? CommonAnnotationsEnvsubst { get; set; }

        [Input("commonLabels")]
        private InputMap<string>? _commonLabels;
        public InputMap<string> CommonLabels
        {
            get => _commonLabels ?? (_commonLabels = new InputMap<string>());
            set => _commonLabels = value;
        }

        [Input("forceCommonAnnotations")]
        public Input<bool>? ForceCommonAnnotations { get; set; }

        [Input("forceCommonLabels")]
        public Input<bool>? ForceCommonLabels { get; set; }

        [Input("images")]
        private InputList<string>? _images;
        public InputList<string> Images
        {
            get => _images ?? (_images = new InputList<string>());
            set => _images = value;
        }

        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        [Input("nameSuffix")]
        public Input<string>? NameSuffix { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("replicas")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecTemplateSpecSourceKustomizeReplicasArgs>? _replicas;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecTemplateSpecSourceKustomizeReplicasArgs> Replicas
        {
            get => _replicas ?? (_replicas = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecTemplateSpecSourceKustomizeReplicasArgs>());
            set => _replicas = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationSetSpecTemplateSpecSourceKustomizeArgs()
        {
        }
        public static new ApplicationSetSpecTemplateSpecSourceKustomizeArgs Empty => new ApplicationSetSpecTemplateSpecSourceKustomizeArgs();
    }
}