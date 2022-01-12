using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    /// <summary>AWS Glue.</summary>
    [JsiiByValue(fqn: "aws.glue.GlueCatalogTableConfig")]
    public class GlueCatalogTableConfig : aws.Glue.IGlueCatalogTableConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#database_name GlueCatalogTable#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#name GlueCatalogTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#catalog_id GlueCatalogTable#catalog_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CatalogId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#description GlueCatalogTable#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#owner GlueCatalogTable#owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Owner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#parameters GlueCatalogTable#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Parameters
        {
            get;
            set;
        }

        /// <summary>partition_index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#partition_index GlueCatalogTable#partition_index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partitionIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTablePartitionIndex\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Glue.IGlueCatalogTablePartitionIndex[]? PartitionIndex
        {
            get;
            set;
        }

        /// <summary>partition_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#partition_keys GlueCatalogTable#partition_keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partitionKeys", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Glue.IGlueCatalogTablePartitionKeys[]? PartitionKeys
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#retention GlueCatalogTable#retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retention", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Retention
        {
            get;
            set;
        }

        /// <summary>storage_descriptor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#storage_descriptor GlueCatalogTable#storage_descriptor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageDescriptor", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptor\"}", isOptional: true, isOverride: true)]
        public aws.Glue.IGlueCatalogTableStorageDescriptor? StorageDescriptor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#table_type GlueCatalogTable#table_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TableType
        {
            get;
            set;
        }

        /// <summary>target_table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#target_table GlueCatalogTable#target_table}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetTable", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableTargetTable\"}", isOptional: true, isOverride: true)]
        public aws.Glue.IGlueCatalogTableTargetTable? TargetTable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#view_expanded_text GlueCatalogTable#view_expanded_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ViewExpandedText
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#view_original_text GlueCatalogTable#view_original_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ViewOriginalText
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
