using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSseKmsEncryptedObjects", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"}}]")]
        public virtual void PutSseKmsEncryptedObjects(aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSseKmsEncryptedObjects")]
        public virtual void ResetSseKmsEncryptedObjects()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference SseKmsEncryptedObjects
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseKmsEncryptedObjectsInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjectsInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
