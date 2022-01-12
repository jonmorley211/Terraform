using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleSourceSelectionCriteria), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteria")]
    public interface IS3BucketReplicationConfigurationRuleSourceSelectionCriteria
    {
        /// <summary>replica_modifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#replica_modifications S3BucketReplicationConfigurationA#replica_modifications}
        /// </remarks>
        [JsiiProperty(name: "replicaModifications", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>sse_kms_encrypted_objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#sse_kms_encrypted_objects S3BucketReplicationConfigurationA#sse_kms_encrypted_objects}
        /// </remarks>
        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleSourceSelectionCriteria), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>replica_modifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#replica_modifications S3BucketReplicationConfigurationA#replica_modifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicaModifications", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications?>();
            }

            /// <summary>sse_kms_encrypted_objects block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#sse_kms_encrypted_objects S3BucketReplicationConfigurationA#sse_kms_encrypted_objects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects?>();
            }
        }
    }
}
