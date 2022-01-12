using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference), fullyQualifiedName: "aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionPasswordEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption\"}}]")]
        public virtual void PutConnectionPasswordEncryption(aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionAtRest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest\"}}]")]
        public virtual void PutEncryptionAtRest(aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest)}, new object[]{@value});
        }

        [JsiiProperty(name: "connectionPasswordEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryptionOutputReference\"}")]
        public virtual aws.Glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryptionOutputReference ConnectionPasswordEncryption
        {
            get => GetInstanceProperty<aws.Glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRestOutputReference\"}")]
        public virtual aws.Glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRestOutputReference EncryptionAtRest
        {
            get => GetInstanceProperty<aws.Glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPasswordEncryptionInput", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption\"}", isOptional: true)]
        public virtual aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption? ConnectionPasswordEncryptionInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtRestInput", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest\"}", isOptional: true)]
        public virtual aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest? EncryptionAtRestInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings\"}", isOptional: true)]
        public virtual aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
