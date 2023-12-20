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
    public sealed class ApplicationSetSpecGeneratorsGit
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitDirectories> Directories;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitFiles> Files;
        public readonly string PathParamPrefix;
        public readonly string RepoURL;
        public readonly int RequeueAfterSeconds;
        public readonly string Revision;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplate Template;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsGit(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitDirectories> directories,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitFiles> files,

            string pathParamPrefix,

            string repoURL,

            int requeueAfterSeconds,

            string revision,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplate template)
        {
            Directories = directories;
            Files = files;
            PathParamPrefix = pathParamPrefix;
            RepoURL = repoURL;
            RequeueAfterSeconds = requeueAfterSeconds;
            Revision = revision;
            Template = template;
        }
    }
}
