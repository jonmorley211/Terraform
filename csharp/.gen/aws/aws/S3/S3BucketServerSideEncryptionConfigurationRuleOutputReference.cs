using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketServerSideEncryptionConfigurationRuleOutputReference), fullyQualifiedName: "aws.s3.S3BucketServerSideEncryptionConfigurationRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketServerSideEncryptionConfigurationRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3BucketServerSideEncryptionConfigurationRuleOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketServerSideEncryptionConfigurationRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketServerSideEncryptionConfigurationRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplyServerSideEncryptionByDefault", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}}]")]
        public virtual void PutApplyServerSideEncryptionByDefault(aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBucketKeyEnabled")]
        public virtual void ResetBucketKeyEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultOutputReference\"}")]
        public virtual aws.S3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultOutputReference ApplyServerSideEncryptionByDefault
        {
            get => GetInstanceProperty<aws.S3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyServerSideEncryptionByDefaultInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault? ApplyServerSideEncryptionByDefaultInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketKeyEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BucketKeyEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bucketKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BucketKeyEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRule\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketServerSideEncryptionConfigurationRule? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketServerSideEncryptionConfigurationRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
