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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas
    {
        public readonly bool Code;
        public readonly string Name;
        public readonly string Value;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas(
            bool code,

            string name,

            string value)
        {
            Code = code;
            Name = name;
            Value = value;
        }
    }
}
