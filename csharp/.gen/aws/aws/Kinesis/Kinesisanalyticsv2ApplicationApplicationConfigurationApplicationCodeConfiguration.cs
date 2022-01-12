using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#code_content_type Kinesisanalyticsv2Application#code_content_type}.</summary>
        [JsiiProperty(name: "codeContentType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CodeContentType
        {
            get;
            set;
        }

        /// <summary>code_content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#code_content Kinesisanalyticsv2Application#code_content}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeContent", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContent
        {
            get;
            set;
        }
    }
}
