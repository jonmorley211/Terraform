using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscription")]
    public class CloudfrontMonitoringSubscriptionMonitoringSubscription : aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription
    {
        /// <summary>realtime_metrics_subscription_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription#realtime_metrics_subscription_config CloudfrontMonitoringSubscription#realtime_metrics_subscription_config}
        /// </remarks>
        [JsiiProperty(name: "realtimeMetricsSubscriptionConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscriptionRealtimeMetricsSubscriptionConfig RealtimeMetricsSubscriptionConfig
        {
            get;
            set;
        }
    }
}
