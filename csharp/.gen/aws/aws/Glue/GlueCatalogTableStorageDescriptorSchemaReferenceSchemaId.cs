using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId")]
    public class GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId : aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#registry_name GlueCatalogTable#registry_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RegistryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#schema_arn GlueCatalogTable#schema_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SchemaArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#schema_name GlueCatalogTable#schema_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SchemaName
        {
            get;
            set;
        }
    }
}
