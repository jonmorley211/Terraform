using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueCatalogTableStorageDescriptorSchemaReference")]
    public class GlueCatalogTableStorageDescriptorSchemaReference : aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#schema_version_number GlueCatalogTable#schema_version_number}.</summary>
        [JsiiProperty(name: "schemaVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double SchemaVersionNumber
        {
            get;
            set;
        }

        /// <summary>schema_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#schema_id GlueCatalogTable#schema_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaId", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}", isOptional: true, isOverride: true)]
        public aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId? SchemaId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#schema_version_id GlueCatalogTable#schema_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SchemaVersionId
        {
            get;
            set;
        }
    }
}
