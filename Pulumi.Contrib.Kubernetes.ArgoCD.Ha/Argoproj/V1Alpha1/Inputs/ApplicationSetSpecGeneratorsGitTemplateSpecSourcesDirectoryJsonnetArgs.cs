// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extVars")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVarsArgs>? _extVars;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVarsArgs> ExtVars
        {
            get => _extVars ?? (_extVars = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVarsArgs>());
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
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlasArgs>? _tlas;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlasArgs> Tlas
        {
            get => _tlas ?? (_tlas = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlasArgs>());
            set => _tlas = value;
        }

        public ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetArgs Empty => new ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetArgs();
    }
}
