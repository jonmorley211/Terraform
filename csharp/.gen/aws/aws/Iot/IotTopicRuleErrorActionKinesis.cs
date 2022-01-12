using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleErrorActionKinesis")]
    public class IotTopicRuleErrorActionKinesis : aws.Iot.IIotTopicRuleErrorActionKinesis
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#stream_name IotTopicRule#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StreamName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#partition_key IotTopicRule#partition_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PartitionKey
        {
            get;
            set;
        }
    }
}
