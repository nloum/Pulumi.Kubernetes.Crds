// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmFileParametersArgs : global::Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmFileParametersArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmFileParametersArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmFileParametersArgs();
    }
}
