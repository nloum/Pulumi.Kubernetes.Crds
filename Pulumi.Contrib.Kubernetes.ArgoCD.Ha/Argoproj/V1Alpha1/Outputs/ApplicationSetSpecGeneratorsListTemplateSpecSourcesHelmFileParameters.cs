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
    public sealed class ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelmFileParameters
    {
        public readonly string Name;
        public readonly string Path;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelmFileParameters(
            string name,

            string path)
        {
            Name = name;
            Path = path;
        }
    }
}
