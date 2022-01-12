using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.DataAwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings), fullyQualifiedName: "aws.glue.DataAwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connectionPasswordEncryption", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ConnectionPasswordEncryption
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EncryptionAtRest
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
