using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectSourceAuth")]
    public class CodebuildProjectSourceAuth : aws.Codebuild.ICodebuildProjectSourceAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#type CodebuildProject#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#resource CodebuildProject#resource}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Resource
        {
            get;
            set;
        }
    }
}
