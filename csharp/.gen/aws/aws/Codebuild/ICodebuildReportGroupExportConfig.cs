using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildReportGroupExportConfig), fullyQualifiedName: "aws.codebuild.CodebuildReportGroupExportConfig")]
    public interface ICodebuildReportGroupExportConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_report_group#type CodebuildReportGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_report_group#s3_destination CodebuildReportGroup#s3_destination}
        /// </remarks>
        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildReportGroupExportConfigS3Destination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination? S3Destination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildReportGroupExportConfig), fullyQualifiedName: "aws.codebuild.CodebuildReportGroupExportConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildReportGroupExportConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_report_group#type CodebuildReportGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>s3_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_report_group#s3_destination CodebuildReportGroup#s3_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildReportGroupExportConfigS3Destination\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination? S3Destination
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination?>();
            }
        }
    }
}
