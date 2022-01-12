using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions")]
    public class Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions : aws.Kinesis.IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#log_stream_arn Kinesisanalyticsv2Application#log_stream_arn}.</summary>
        [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LogStreamArn
        {
            get;
            set;
        }
    }
}
