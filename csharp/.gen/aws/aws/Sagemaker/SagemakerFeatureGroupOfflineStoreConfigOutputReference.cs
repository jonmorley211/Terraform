using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerFeatureGroupOfflineStoreConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerFeatureGroupOfflineStoreConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerFeatureGroupOfflineStoreConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroupOfflineStoreConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroupOfflineStoreConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataCatalogConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}}]")]
        public virtual void PutDataCatalogConfig(aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3StorageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}}]")]
        public virtual void PutS3StorageConfig(aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataCatalogConfig")]
        public virtual void ResetDataCatalogConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableGlueTableCreation")]
        public virtual void ResetDisableGlueTableCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataCatalogConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfigOutputReference DataCatalogConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfigOutputReference>()!;
        }

        [JsiiProperty(name: "s3StorageConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfigOutputReference S3StorageConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCatalogConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig? DataCatalogConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableGlueTableCreationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableGlueTableCreationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3StorageConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig? S3StorageConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig?>();
        }

        [JsiiProperty(name: "disableGlueTableCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisableGlueTableCreation
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
