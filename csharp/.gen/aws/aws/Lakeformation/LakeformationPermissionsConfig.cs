using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    #pragma warning disable CS8618

    /// <summary>AWS Lake Formation.</summary>
    [JsiiByValue(fqn: "aws.lakeformation.LakeformationPermissionsConfig")]
    public class LakeformationPermissionsConfig : aws.Lakeformation.ILakeformationPermissionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#permissions LakeformationPermissions#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Permissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#principal LakeformationPermissions#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Principal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#catalog_id LakeformationPermissions#catalog_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CatalogId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#catalog_resource LakeformationPermissions#catalog_resource}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CatalogResource
        {
            get;
            set;
        }

        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#database LakeformationPermissions#database}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDatabase\"}", isOptional: true, isOverride: true)]
        public aws.Lakeformation.ILakeformationPermissionsDatabase? Database
        {
            get;
            set;
        }

        /// <summary>data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#data_location LakeformationPermissions#data_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDataLocation\"}", isOptional: true, isOverride: true)]
        public aws.Lakeformation.ILakeformationPermissionsDataLocation? DataLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#permissions_with_grant_option LakeformationPermissions#permissions_with_grant_option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? PermissionsWithGrantOption
        {
            get;
            set;
        }

        /// <summary>table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#table LakeformationPermissions#table}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTable\"}", isOptional: true, isOverride: true)]
        public aws.Lakeformation.ILakeformationPermissionsTable? Table
        {
            get;
            set;
        }

        /// <summary>table_with_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#table_with_columns LakeformationPermissions#table_with_columns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTableWithColumns\"}", isOptional: true, isOverride: true)]
        public aws.Lakeformation.ILakeformationPermissionsTableWithColumns? TableWithColumns
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
