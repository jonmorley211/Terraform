using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration")]
    public class S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration : aws.S3.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#replica_kms_key_id S3BucketReplicationConfigurationA#replica_kms_key_id}.</summary>
        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReplicaKmsKeyId
        {
            get;
            set;
        }
    }
}
