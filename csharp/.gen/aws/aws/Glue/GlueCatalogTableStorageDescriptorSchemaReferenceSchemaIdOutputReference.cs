using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference), fullyQualifiedName: "aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRegistryName")]
        public virtual void ResetRegistryName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaArn")]
        public virtual void ResetSchemaArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaName")]
        public virtual void ResetSchemaName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "registryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId?>();
            set => SetInstanceProperty(value);
        }
    }
}
