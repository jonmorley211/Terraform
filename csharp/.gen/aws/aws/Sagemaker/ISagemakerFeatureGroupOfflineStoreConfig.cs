using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupOfflineStoreConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfig")]
    public interface ISagemakerFeatureGroupOfflineStoreConfig
    {
        /// <summary>s3_storage_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#s3_storage_config SagemakerFeatureGroup#s3_storage_config}
        /// </remarks>
        [JsiiProperty(name: "s3StorageConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}")]
        aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig S3StorageConfig
        {
            get;
        }

        /// <summary>data_catalog_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#data_catalog_config SagemakerFeatureGroup#data_catalog_config}
        /// </remarks>
        [JsiiProperty(name: "dataCatalogConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig? DataCatalogConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#disable_glue_table_creation SagemakerFeatureGroup#disable_glue_table_creation}.</summary>
        [JsiiProperty(name: "disableGlueTableCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableGlueTableCreation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupOfflineStoreConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_storage_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#s3_storage_config SagemakerFeatureGroup#s3_storage_config}
            /// </remarks>
            [JsiiProperty(name: "s3StorageConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}")]
            public aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig S3StorageConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig>()!;
            }

            /// <summary>data_catalog_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#data_catalog_config SagemakerFeatureGroup#data_catalog_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataCatalogConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig? DataCatalogConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#disable_glue_table_creation SagemakerFeatureGroup#disable_glue_table_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableGlueTableCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableGlueTableCreation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
