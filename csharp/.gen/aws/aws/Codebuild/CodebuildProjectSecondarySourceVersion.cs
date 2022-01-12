using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectSecondarySourceVersion")]
    public class CodebuildProjectSecondarySourceVersion : aws.Codebuild.ICodebuildProjectSecondarySourceVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_identifier CodebuildProject#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_version CodebuildProject#source_version}.</summary>
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceVersion
        {
            get;
            set;
        }
    }
}
