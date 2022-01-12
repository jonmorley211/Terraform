using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRulesDestination")]
    public class S3BucketReplicationConfigurationRulesDestination : aws.S3.IS3BucketReplicationConfigurationRulesDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#bucket S3Bucket#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>access_control_translation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#access_control_translation S3Bucket#access_control_translation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation? AccessControlTranslation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#account_id S3Bucket#account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccountId
        {
            get;
            set;
        }

        /// <summary>metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#metrics S3Bucket#metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationMetrics\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRulesDestinationMetrics? Metrics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#replica_kms_key_id S3Bucket#replica_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplicaKmsKeyId
        {
            get;
            set;
        }

        /// <summary>replication_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#replication_time S3Bucket#replication_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicationTime", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestinationReplicationTime\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRulesDestinationReplicationTime? ReplicationTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#storage_class S3Bucket#storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StorageClass
        {
            get;
            set;
        }
    }
}
