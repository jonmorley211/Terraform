using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings aws_glue_data_catalog_encryption_settings}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.GlueDataCatalogEncryptionSettings), fullyQualifiedName: "aws.glue.GlueDataCatalogEncryptionSettings", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsConfig\"}}]")]
    public class GlueDataCatalogEncryptionSettings : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/glue_data_catalog_encryption_settings aws_glue_data_catalog_encryption_settings} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueDataCatalogEncryptionSettings(Constructs.Construct scope, string id, aws.Glue.IGlueDataCatalogEncryptionSettingsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueDataCatalogEncryptionSettings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueDataCatalogEncryptionSettings(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataCatalogEncryptionSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings\"}}]")]
        public virtual void PutDataCatalogEncryptionSettings(aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Glue.GlueDataCatalogEncryptionSettings))!;

        [JsiiProperty(name: "dataCatalogEncryptionSettings", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference\"}")]
        public virtual aws.Glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference DataCatalogEncryptionSettings
        {
            get => GetInstanceProperty<aws.Glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCatalogEncryptionSettingsInput", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings\"}", isOptional: true)]
        public virtual aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings? DataCatalogEncryptionSettingsInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
