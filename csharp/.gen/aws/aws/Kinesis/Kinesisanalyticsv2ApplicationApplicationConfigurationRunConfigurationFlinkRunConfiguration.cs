using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#allow_non_restored_state Kinesisanalyticsv2Application#allow_non_restored_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowNonRestoredState", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? AllowNonRestoredState
        {
            get;
            set;
        }
    }
}
