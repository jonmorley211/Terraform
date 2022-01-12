using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleIotEvents")]
    public class IotTopicRuleIotEvents : aws.Iot.IIotTopicRuleIotEvents
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#input_name IotTopicRule#input_name}.</summary>
        [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InputName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#message_id IotTopicRule#message_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MessageId
        {
            get;
            set;
        }
    }
}
