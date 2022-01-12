using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings")]
    public class GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings : aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings
    {
        /// <summary>connection_password_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#connection_password_encryption GlueDataCatalogEncryptionSettings#connection_password_encryption}
        /// </remarks>
        [JsiiProperty(name: "connectionPasswordEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption\"}", isOverride: true)]
        public aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption ConnectionPasswordEncryption
        {
            get;
            set;
        }

        /// <summary>encryption_at_rest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings#encryption_at_rest GlueDataCatalogEncryptionSettings#encryption_at_rest}
        /// </remarks>
        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest\"}", isOverride: true)]
        public aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest EncryptionAtRest
        {
            get;
            set;
        }
    }
}
