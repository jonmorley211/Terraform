using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration")]
    public interface IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#replica_kms_key_id S3BucketReplicationConfigurationA#replica_kms_key_id}.</summary>
        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicaKmsKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#replica_kms_key_id S3BucketReplicationConfigurationA#replica_kms_key_id}.</summary>
            [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicaKmsKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
