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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas
    {
        public readonly bool Code;
        public readonly string Name;
        public readonly string Value;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas(
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
