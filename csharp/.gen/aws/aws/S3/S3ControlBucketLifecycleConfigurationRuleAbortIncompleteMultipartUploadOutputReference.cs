using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference), fullyQualifiedName: "aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysAfterInitiationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DaysAfterInitiationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysAfterInitiation
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload?>();
            set => SetInstanceProperty(value);
        }
    }
}
