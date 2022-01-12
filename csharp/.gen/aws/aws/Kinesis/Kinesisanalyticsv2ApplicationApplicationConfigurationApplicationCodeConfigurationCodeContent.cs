using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent
    {
        /// <summary>s3_content_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#s3_content_location Kinesisanalyticsv2Application#s3_content_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3ContentLocation", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation? S3ContentLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#text_content Kinesisanalyticsv2Application#text_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TextContent
        {
            get;
            set;
        }
    }
}
