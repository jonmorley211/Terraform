using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEventThreshold", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold\"}}]")]
        public virtual void PutEventThreshold(aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEventThreshold")]
        public virtual void ResetEventThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "eventThreshold", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThresholdOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThresholdOutputReference EventThreshold
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThresholdOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventThresholdInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold? EventThresholdInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetrics\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetrics? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
