using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest), fullyQualifiedName: "aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest")]
    public interface IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#catalog_encryption_mode GlueDataCatalogEncryptionSettings#catalog_encryption_mode}.</summary>
        [JsiiProperty(name: "catalogEncryptionMode", typeJson: "{\"primitive\":\"string\"}")]
        string CatalogEncryptionMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#sse_aws_kms_key_id GlueDataCatalogEncryptionSettings#sse_aws_kms_key_id}.</summary>
        [JsiiProperty(name: "sseAwsKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SseAwsKmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest), fullyQualifiedName: "aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#catalog_encryption_mode GlueDataCatalogEncryptionSettings#catalog_encryption_mode}.</summary>
            [JsiiProperty(name: "catalogEncryptionMode", typeJson: "{\"primitive\":\"string\"}")]
            public string CatalogEncryptionMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#sse_aws_kms_key_id GlueDataCatalogEncryptionSettings#sse_aws_kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sseAwsKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SseAwsKmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
