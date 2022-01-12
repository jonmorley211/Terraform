using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codeartifact
{
    [JsiiInterface(nativeType: typeof(ICodeartifactRepositoryUpstream), fullyQualifiedName: "aws.codeartifact.CodeartifactRepositoryUpstream")]
    public interface ICodeartifactRepositoryUpstream
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codeartifact_repository#repository_name CodeartifactRepository#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodeartifactRepositoryUpstream), fullyQualifiedName: "aws.codeartifact.CodeartifactRepositoryUpstream")]
        internal sealed class _Proxy : DeputyBase, aws.Codeartifact.ICodeartifactRepositoryUpstream
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codeartifact_repository#repository_name CodeartifactRepository#repository_name}.</summary>
            [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
