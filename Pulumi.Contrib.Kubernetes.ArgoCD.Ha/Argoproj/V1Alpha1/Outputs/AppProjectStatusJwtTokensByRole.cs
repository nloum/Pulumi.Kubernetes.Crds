// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// JWTTokens represents a list of JWT tokens
    /// </summary>
    [OutputType]
    public sealed class AppProjectStatusJwtTokensByRole
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.AppProjectStatusJwtTokensByRoleItems> Items;

        [OutputConstructor]
        private AppProjectStatusJwtTokensByRole(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.AppProjectStatusJwtTokensByRoleItems> items)
        {
            Items = items;
        }
    }
}
