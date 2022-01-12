using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationInputsStartingPositionConfiguration")]
    public class KinesisAnalyticsApplicationInputsStartingPositionConfiguration : aws.Kinesis.IKinesisAnalyticsApplicationInputsStartingPositionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#starting_position KinesisAnalyticsApplication#starting_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StartingPosition
        {
            get;
            set;
        }
    }
}
