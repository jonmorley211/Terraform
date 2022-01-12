using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkteamNotificationConfiguration), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamNotificationConfiguration")]
    public interface ISagemakerWorkteamNotificationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#notification_topic_arn SagemakerWorkteam#notification_topic_arn}.</summary>
        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationTopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkteamNotificationConfiguration), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamNotificationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerWorkteamNotificationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#notification_topic_arn SagemakerWorkteam#notification_topic_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationTopicArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
