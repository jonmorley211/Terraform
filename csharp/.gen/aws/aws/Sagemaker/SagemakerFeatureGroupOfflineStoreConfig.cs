using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfig")]
    public class SagemakerFeatureGroupOfflineStoreConfig : aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig
    {
        /// <summary>s3_storage_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#s3_storage_config SagemakerFeatureGroup#s3_storage_config}
        /// </remarks>
        [JsiiProperty(name: "s3StorageConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig S3StorageConfig
        {
            get;
            set;
        }

        /// <summary>data_catalog_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#data_catalog_config SagemakerFeatureGroup#data_catalog_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataCatalogConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig? DataCatalogConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#disable_glue_table_creation SagemakerFeatureGroup#disable_glue_table_creation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableGlueTableCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? DisableGlueTableCreation
        {
            get;
            set;
        }
    }
}
