using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iot.IotTopicRuleDynamodbv2")]
    public class IotTopicRuleDynamodbv2 : aws.Iot.IIotTopicRuleDynamodbv2
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>put_item block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#put_item IotTopicRule#put_item}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "putItem", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2PutItem\"}", isOptional: true, isOverride: true)]
        public aws.Iot.IIotTopicRuleDynamodbv2PutItem? PutItem
        {
            get;
            set;
        }
    }
}
