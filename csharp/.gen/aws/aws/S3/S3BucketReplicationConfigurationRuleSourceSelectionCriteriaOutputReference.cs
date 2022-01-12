using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReplicaModifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications\"}}]")]
        public virtual void PutReplicaModifications(aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSseKmsEncryptedObjects", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects\"}}]")]
        public virtual void PutSseKmsEncryptedObjects(aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetReplicaModifications")]
        public virtual void ResetReplicaModifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSseKmsEncryptedObjects")]
        public virtual void ResetSseKmsEncryptedObjects()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "replicaModifications", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModificationsOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModificationsOutputReference ReplicaModifications
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModificationsOutputReference>()!;
        }

        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference SseKmsEncryptedObjects
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaModificationsInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications? ReplicaModificationsInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseKmsEncryptedObjectsInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjectsInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteria\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
