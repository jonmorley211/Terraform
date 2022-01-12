using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    /// <summary>AWS Lake Formation.</summary>
    [JsiiInterface(nativeType: typeof(ILakeformationPermissionsConfig), fullyQualifiedName: "aws.lakeformation.LakeformationPermissionsConfig")]
    public interface ILakeformationPermissionsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#permissions LakeformationPermissions#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Permissions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#principal LakeformationPermissions#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#catalog_id LakeformationPermissions#catalog_id}.</summary>
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#catalog_resource LakeformationPermissions#catalog_resource}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#database LakeformationPermissions#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDatabase\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.ILakeformationPermissionsDatabase? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#data_location LakeformationPermissions#data_location}
        /// </remarks>
        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDataLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.ILakeformationPermissionsDataLocation? DataLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#permissions_with_grant_option LakeformationPermissions#permissions_with_grant_option}.</summary>
        [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PermissionsWithGrantOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#table LakeformationPermissions#table}
        /// </remarks>
        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.ILakeformationPermissionsTable? Table
        {
            get
            {
                return null;
            }
        }

        /// <summary>table_with_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#table_with_columns LakeformationPermissions#table_with_columns}
        /// </remarks>
        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.ILakeformationPermissionsTableWithColumns? TableWithColumns
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Lake Formation.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILakeformationPermissionsConfig), fullyQualifiedName: "aws.lakeformation.LakeformationPermissionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lakeformation.ILakeformationPermissionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#permissions LakeformationPermissions#permissions}.</summary>
            [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Permissions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#principal LakeformationPermissions#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#catalog_id LakeformationPermissions#catalog_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#catalog_resource LakeformationPermissions#catalog_resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CatalogResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#database LakeformationPermissions#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDatabase\"}", isOptional: true)]
            public aws.Lakeformation.ILakeformationPermissionsDatabase? Database
            {
                get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsDatabase?>();
            }

            /// <summary>data_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#data_location LakeformationPermissions#data_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDataLocation\"}", isOptional: true)]
            public aws.Lakeformation.ILakeformationPermissionsDataLocation? DataLocation
            {
                get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsDataLocation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#permissions_with_grant_option LakeformationPermissions#permissions_with_grant_option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PermissionsWithGrantOption
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#table LakeformationPermissions#table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTable\"}", isOptional: true)]
            public aws.Lakeformation.ILakeformationPermissionsTable? Table
            {
                get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsTable?>();
            }

            /// <summary>table_with_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions#table_with_columns LakeformationPermissions#table_with_columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTableWithColumns\"}", isOptional: true)]
            public aws.Lakeformation.ILakeformationPermissionsTableWithColumns? TableWithColumns
            {
                get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsTableWithColumns?>();
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
