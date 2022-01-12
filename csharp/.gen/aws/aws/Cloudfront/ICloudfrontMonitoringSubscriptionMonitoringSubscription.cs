using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMonitoringSubscriptionMonitoringSubscription), fullyQualifiedName: "aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscription")]
    public interface ICloudfrontMonitoringSubscriptionMonitoringSubscription
    {
        /// <summary>realtime_metrics_subscription_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription#realtime_metrics_subscription_config CloudfrontMonitoringSubscription#realtime_metrics_subscription_config}
        /// </remarks>
        [JsiiProperty(name: "realtimeMetricsSubscriptionConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig\"}")]
        aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig RealtimeMetricsSubscriptionConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMonitoringSubscriptionMonitoringSubscription), fullyQualifiedName: "aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscription")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>realtime_metrics_subscription_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription#realtime_metrics_subscription_config CloudfrontMonitoringSubscription#realtime_metrics_subscription_config}
            /// </remarks>
            [JsiiProperty(name: "realtimeMetricsSubscriptionConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig\"}")]
            public aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig RealtimeMetricsSubscriptionConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig>()!;
            }
        }
    }
}
