using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketReplicationConfigurationRuleDestinationOutputReference), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRuleDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketReplicationConfigurationRuleDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3BucketReplicationConfigurationRuleDestinationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessControlTranslation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation\"}}]")]
        public virtual void PutAccessControlTranslation(aws.S3.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration\"}}]")]
        public virtual void PutEncryptionConfiguration(aws.S3.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetrics\"}}]")]
        public virtual void PutMetrics(aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicationTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTime\"}}]")]
        public virtual void PutReplicationTime(aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessControlTranslation")]
        public virtual void ResetAccessControlTranslation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccount")]
        public virtual void ResetAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionConfiguration")]
        public virtual void ResetEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetrics")]
        public virtual void ResetMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationTime")]
        public virtual void ResetReplicationTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageClass")]
        public virtual void ResetStorageClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslationOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslationOutputReference AccessControlTranslation
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslationOutputReference>()!;
        }

        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfigurationOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfigurationOutputReference EncryptionConfiguration
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference Metrics
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleDestinationMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "replicationTime", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTimeOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationRuleDestinationReplicationTimeOutputReference ReplicationTime
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationRuleDestinationReplicationTimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlTranslationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation? AccessControlTranslationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration? EncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationMetrics\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetrics? MetricsInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationTimeInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTime\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTime? ReplicationTimeInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Account
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestination\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfigurationRuleDestination? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
