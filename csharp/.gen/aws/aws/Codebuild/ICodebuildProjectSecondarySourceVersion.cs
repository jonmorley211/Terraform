using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySourceVersion), fullyQualifiedName: "aws.codebuild.CodebuildProjectSecondarySourceVersion")]
    public interface ICodebuildProjectSecondarySourceVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_identifier CodebuildProject#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string SourceIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_version CodebuildProject#source_version}.</summary>
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySourceVersion), fullyQualifiedName: "aws.codebuild.CodebuildProjectSecondarySourceVersion")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectSecondarySourceVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_identifier CodebuildProject#source_identifier}.</summary>
            [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_version CodebuildProject#source_version}.</summary>
            [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
