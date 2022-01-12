using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest")]
    public class GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest : aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#catalog_encryption_mode GlueDataCatalogEncryptionSettings#catalog_encryption_mode}.</summary>
        [JsiiProperty(name: "catalogEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CatalogEncryptionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#sse_aws_kms_key_id GlueDataCatalogEncryptionSettings#sse_aws_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseAwsKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SseAwsKmsKeyId
        {
            get;
            set;
        }
    }
}
