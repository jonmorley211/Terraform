using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    [JsiiByValue(fqn: "aws.pinpoint.PinpointAppLimits")]
    public class PinpointAppLimits : aws.Pinpoint.IPinpointAppLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#daily PinpointApp#daily}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daily", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Daily
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#maximum_duration PinpointApp#maximum_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#messages_per_second PinpointApp#messages_per_second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messagesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MessagesPerSecond
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#total PinpointApp#total}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Total
        {
            get;
            set;
        }
    }
}
