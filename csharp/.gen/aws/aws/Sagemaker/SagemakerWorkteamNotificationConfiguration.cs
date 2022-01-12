using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerWorkteamNotificationConfiguration")]
    public class SagemakerWorkteamNotificationConfiguration : aws.Sagemaker.ISagemakerWorkteamNotificationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#notification_topic_arn SagemakerWorkteam#notification_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NotificationTopicArn
        {
            get;
            set;
        }
    }
}
