// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmParametersArgs : global::Pulumi.ResourceArgs
    {
        [Input("forceString")]
        public Input<bool>? ForceString { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmParametersArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmParametersArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmParametersArgs();
    }
}
