using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings), fullyQualifiedName: "aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings")]
    public interface IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings
    {
        /// <summary>connection_password_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#connection_password_encryption GlueDataCatalogEncryptionSettings#connection_password_encryption}
        /// </remarks>
        [JsiiProperty(name: "connectionPasswordEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption\"}")]
        aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption ConnectionPasswordEncryption
        {
            get;
        }

        /// <summary>encryption_at_rest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#encryption_at_rest GlueDataCatalogEncryptionSettings#encryption_at_rest}
        /// </remarks>
        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest\"}")]
        aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest EncryptionAtRest
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings), fullyQualifiedName: "aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connection_password_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#connection_password_encryption GlueDataCatalogEncryptionSettings#connection_password_encryption}
            /// </remarks>
            [JsiiProperty(name: "connectionPasswordEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption\"}")]
            public aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption ConnectionPasswordEncryption
            {
                get => GetInstanceProperty<aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption>()!;
            }

            /// <summary>encryption_at_rest block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#encryption_at_rest GlueDataCatalogEncryptionSettings#encryption_at_rest}
            /// </remarks>
            [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest\"}")]
            public aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest EncryptionAtRest
            {
                get => GetInstanceProperty<aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest>()!;
            }
        }
    }
}
