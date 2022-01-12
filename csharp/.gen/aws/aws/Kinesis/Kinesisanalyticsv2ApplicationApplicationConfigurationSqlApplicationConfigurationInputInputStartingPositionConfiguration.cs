using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#input_starting_position Kinesisanalyticsv2Application#input_starting_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputStartingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InputStartingPosition
        {
            get;
            set;
        }
    }
}
