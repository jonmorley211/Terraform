using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationReplicationTime), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTime")]
    public interface IS3BucketReplicationConfigurationRuleDestinationReplicationTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#time S3BucketReplicationConfigurationA#time}
        /// </remarks>
        [JsiiProperty(name: "time", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTimeTime\"}")]
        aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime Time
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationReplicationTime), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTime")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTime
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

            /// <summary>time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#time S3BucketReplicationConfigurationA#time}
            /// </remarks>
            [JsiiProperty(name: "time", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTimeTime\"}")]
            public aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime Time
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime>()!;
            }
        }
    }
}
