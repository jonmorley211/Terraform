using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    /// <summary>AWS Lake Formation.</summary>
    [JsiiInterface(nativeType: typeof(ILakeformationDataLakeSettingsConfig), fullyQualifiedName: "aws.lakeformation.LakeformationDataLakeSettingsConfig")]
    public interface ILakeformationDataLakeSettingsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#admins LakeformationDataLakeSettings#admins}.</summary>
        [JsiiProperty(name: "admins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Admins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#catalog_id LakeformationDataLakeSettings#catalog_id}.</summary>
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogId
        {
            get
            {
                return null;
            }
        }

        /// <summary>create_database_default_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#create_database_default_permissions LakeformationDataLakeSettings#create_database_default_permissions}
        /// </remarks>
        [JsiiProperty(name: "createDatabaseDefaultPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateDatabaseDefaultPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[]? CreateDatabaseDefaultPermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>create_table_default_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#create_table_default_permissions LakeformationDataLakeSettings#create_table_default_permissions}
        /// </remarks>
        [JsiiProperty(name: "createTableDefaultPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateTableDefaultPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions[]? CreateTableDefaultPermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#trusted_resource_owners LakeformationDataLakeSettings#trusted_resource_owners}.</summary>
        [JsiiProperty(name: "trustedResourceOwners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedResourceOwners
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Lake Formation.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILakeformationDataLakeSettingsConfig), fullyQualifiedName: "aws.lakeformation.LakeformationDataLakeSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lakeformation.ILakeformationDataLakeSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#admins LakeformationDataLakeSettings#admins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "admins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Admins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#catalog_id LakeformationDataLakeSettings#catalog_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>create_database_default_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#create_database_default_permissions LakeformationDataLakeSettings#create_database_default_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createDatabaseDefaultPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateDatabaseDefaultPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Lakeformation.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[]? CreateDatabaseDefaultPermissions
            {
                get => GetInstanceProperty<aws.Lakeformation.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[]?>();
            }

            /// <summary>create_table_default_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#create_table_default_permissions LakeformationDataLakeSettings#create_table_default_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createTableDefaultPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateTableDefaultPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions[]? CreateTableDefaultPermissions
            {
                get => GetInstanceProperty<aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#trusted_resource_owners LakeformationDataLakeSettings#trusted_resource_owners}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedResourceOwners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedResourceOwners
            {
                get => GetInstanceProperty<string[]?>();
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
