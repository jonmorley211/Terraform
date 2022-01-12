using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>AWS CloudFront.</summary>
    [JsiiInterface(nativeType: typeof(ICloudfrontMonitoringSubscriptionConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontMonitoringSubscriptionConfig")]
    public interface ICloudfrontMonitoringSubscriptionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription#distribution_id CloudfrontMonitoringSubscription#distribution_id}.</summary>
        [JsiiProperty(name: "distributionId", typeJson: "{\"primitive\":\"string\"}")]
        string DistributionId
        {
            get;
        }

        /// <summary>monitoring_subscription block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription#monitoring_subscription CloudfrontMonitoringSubscription#monitoring_subscription}
        /// </remarks>
        [JsiiProperty(name: "monitoringSubscription", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscription\"}")]
        aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription MonitoringSubscription
        {
            get;
        }

        /// <summary>AWS CloudFront.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMonitoringSubscriptionConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontMonitoringSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontMonitoringSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription#distribution_id CloudfrontMonitoringSubscription#distribution_id}.</summary>
            [JsiiProperty(name: "distributionId", typeJson: "{\"primitive\":\"string\"}")]
            public string DistributionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>monitoring_subscription block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription#monitoring_subscription CloudfrontMonitoringSubscription#monitoring_subscription}
            /// </remarks>
            [JsiiProperty(name: "monitoringSubscription", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscription\"}")]
            public aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription MonitoringSubscription
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
