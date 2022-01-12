using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference), fullyQualifiedName: "aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSchemaId", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}}]")]
        public virtual void PutSchemaId(aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSchemaId")]
        public virtual void ResetSchemaId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaVersionId")]
        public virtual void ResetSchemaVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "schemaId", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference\"}")]
        public virtual aws.Glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference SchemaId
        {
            get => GetInstanceProperty<aws.Glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaIdInput", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId? SchemaIdInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaVersionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaVersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaVersionNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SchemaVersionNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "schemaVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaVersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SchemaVersionNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReference\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference?>();
            set => SetInstanceProperty(value);
        }
    }
}
