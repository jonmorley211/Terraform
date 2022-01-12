using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectSourceBuildStatusConfig")]
    public class CodebuildProjectSourceBuildStatusConfig : aws.Codebuild.ICodebuildProjectSourceBuildStatusConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#context CodebuildProject#context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "context", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Context
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#target_url CodebuildProject#target_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetUrl
        {
            get;
            set;
        }
    }
}
