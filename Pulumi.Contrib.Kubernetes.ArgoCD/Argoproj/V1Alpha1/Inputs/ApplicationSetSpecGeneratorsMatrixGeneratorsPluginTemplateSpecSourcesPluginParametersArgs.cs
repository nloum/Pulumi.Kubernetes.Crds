// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginParametersArgs : global::Pulumi.ResourceArgs
    {
        [Input("array")]
        private InputList<string>? _array;
        public InputList<string> Array
        {
            get => _array ?? (_array = new InputList<string>());
            set => _array = value;
        }

        [Input("map")]
        private InputMap<string>? _map;
        public InputMap<string> Map
        {
            get => _map ?? (_map = new InputMap<string>());
            set => _map = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("string")]
        public Input<string>? String { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginParametersArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginParametersArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginParametersArgs();
    }
}