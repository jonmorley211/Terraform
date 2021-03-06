using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySourcesBuildStatusConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectSecondarySourcesBuildStatusConfig")]
    public interface ICodebuildProjectSecondarySourcesBuildStatusConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#context CodebuildProject#context}.</summary>
        [JsiiProperty(name: "context", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Context
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#target_url CodebuildProject#target_url}.</summary>
        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySourcesBuildStatusConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectSecondarySourcesBuildStatusConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectSecondarySourcesBuildStatusConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#context CodebuildProject#context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "context", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Context
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#target_url CodebuildProject#target_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
