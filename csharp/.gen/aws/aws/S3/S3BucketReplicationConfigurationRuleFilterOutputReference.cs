using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketReplicationConfigurationRuleFilterOutputReference), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketReplicationConfigurationRuleFilterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3BucketReplicationConfigurationRuleFilterOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterAnd\"}}]")]
        public virtual void PutAnd(aws.S3.IS3BucketReplicationConfigurationRuleFilterAnd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleFilterAnd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterTag\"}}]")]
        public virtual void PutTag(aws.S3.IS3BucketReplicationConfigurationRuleFilterTag @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleFilterTag)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnd")]
        public virtual void ResetAnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterAndOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleFilterAndOutputReference And
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleFilterAndOutputReference>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterTagOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleFilterTagOutputReference Tag
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleFilterTagOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterAnd\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleFilterAnd? AndInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleFilterAnd?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterTag\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleFilterTag? TagInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleFilterTag?>();
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilter\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleFilter? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
