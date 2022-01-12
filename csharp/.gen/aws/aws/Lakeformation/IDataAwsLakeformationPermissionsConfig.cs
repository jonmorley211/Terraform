using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    /// <summary>AWS Lake Formation.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsLakeformationPermissionsConfig), fullyQualifiedName: "aws.lakeformation.DataAwsLakeformationPermissionsConfig")]
    public interface IDataAwsLakeformationPermissionsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#principal DataAwsLakeformationPermissions#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#catalog_id DataAwsLakeformationPermissions#catalog_id}.</summary>
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#catalog_resource DataAwsLakeformationPermissions#catalog_resource}.</summary>
        [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CatalogResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#database DataAwsLakeformationPermissions#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDatabase\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.IDataAwsLakeformationPermissionsDatabase? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#data_location DataAwsLakeformationPermissions#data_location}
        /// </remarks>
        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDataLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.IDataAwsLakeformationPermissionsDataLocation? DataLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#table DataAwsLakeformationPermissions#table}
        /// </remarks>
        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.IDataAwsLakeformationPermissionsTable? Table
        {
            get
            {
                return null;
            }
        }

        /// <summary>table_with_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#table_with_columns DataAwsLakeformationPermissions#table_with_columns}
        /// </remarks>
        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.IDataAwsLakeformationPermissionsTableWithColumns? TableWithColumns
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Lake Formation.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsLakeformationPermissionsConfig), fullyQualifiedName: "aws.lakeformation.DataAwsLakeformationPermissionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lakeformation.IDataAwsLakeformationPermissionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#principal DataAwsLakeformationPermissions#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#catalog_id DataAwsLakeformationPermissions#catalog_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#catalog_resource DataAwsLakeformationPermissions#catalog_resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CatalogResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#database DataAwsLakeformationPermissions#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDatabase\"}", isOptional: true)]
            public aws.Lakeformation.IDataAwsLakeformationPermissionsDatabase? Database
            {
                get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsDatabase?>();
            }

            /// <summary>data_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#data_location DataAwsLakeformationPermissions#data_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDataLocation\"}", isOptional: true)]
            public aws.Lakeformation.IDataAwsLakeformationPermissionsDataLocation? DataLocation
            {
                get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsDataLocation?>();
            }

            /// <summary>table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#table DataAwsLakeformationPermissions#table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTable\"}", isOptional: true)]
            public aws.Lakeformation.IDataAwsLakeformationPermissionsTable? Table
            {
                get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsTable?>();
            }

            /// <summary>table_with_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions#table_with_columns DataAwsLakeformationPermissions#table_with_columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTableWithColumns\"}", isOptional: true)]
            public aws.Lakeformation.IDataAwsLakeformationPermissionsTableWithColumns? TableWithColumns
            {
                get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsTableWithColumns?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
