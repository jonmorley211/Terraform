using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildReportGroupExportConfig")]
    public class CodebuildReportGroupExportConfig : aws.Codebuild.ICodebuildReportGroupExportConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_report_group#type CodebuildReportGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_report_group#s3_destination CodebuildReportGroup#s3_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildReportGroupExportConfigS3Destination\"}", isOptional: true, isOverride: true)]
        public aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination? S3Destination
        {
            get;
            set;
        }
    }
}
