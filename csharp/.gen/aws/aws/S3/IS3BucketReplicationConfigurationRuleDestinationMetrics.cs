using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationMetrics), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationMetrics")]
    public interface IS3BucketReplicationConfigurationRuleDestinationMetrics
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>event_threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#event_threshold S3BucketReplicationConfigurationA#event_threshold}
        /// </remarks>
        [JsiiProperty(name: "eventThreshold", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold? EventThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationMetrics), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationMetrics")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetrics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>event_threshold block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#event_threshold S3BucketReplicationConfigurationA#event_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventThreshold", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold? EventThreshold
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold?>();
            }
        }
    }
}
