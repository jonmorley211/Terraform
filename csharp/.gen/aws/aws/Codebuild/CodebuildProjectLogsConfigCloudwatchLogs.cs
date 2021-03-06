using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs")]
    public class CodebuildProjectLogsConfigCloudwatchLogs : aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#group_name CodebuildProject#group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#status CodebuildProject#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#stream_name CodebuildProject#stream_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StreamName
        {
            get;
            set;
        }
    }
}
