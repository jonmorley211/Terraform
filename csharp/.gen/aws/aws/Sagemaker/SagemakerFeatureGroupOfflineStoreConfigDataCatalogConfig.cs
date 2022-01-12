using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig")]
    public class SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig : aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#catalog SagemakerFeatureGroup#catalog}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalog", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Catalog
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#database SagemakerFeatureGroup#database}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Database
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#table_name SagemakerFeatureGroup#table_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TableName
        {
            get;
            set;
        }
    }
}
