using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetDeadLetterConfig")]
    public class CloudwatchEventTargetDeadLetterConfig : aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#arn CloudwatchEventTarget#arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Arn
        {
            get;
            set;
        }
    }
}
