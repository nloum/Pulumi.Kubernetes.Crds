// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extVars")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVarsArgs>? _extVars;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVarsArgs> ExtVars
        {
            get => _extVars ?? (_extVars = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVarsArgs>());
            set => _extVars = value;
        }

        [Input("libs")]
        private InputList<string>? _libs;
        public InputList<string> Libs
        {
            get => _libs ?? (_libs = new InputList<string>());
            set => _libs = value;
        }

        [Input("tlas")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlasArgs>? _tlas;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlasArgs> Tlas
        {
            get => _tlas ?? (_tlas = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlasArgs>());
            set => _tlas = value;
        }

        public ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetArgs Empty => new ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetArgs();
    }
}