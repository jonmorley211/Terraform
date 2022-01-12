using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions aws_lakeformation_permissions}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lakeformation.DataAwsLakeformationPermissions), fullyQualifiedName: "aws.lakeformation.DataAwsLakeformationPermissions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsConfig\"}}]")]
    public class DataAwsLakeformationPermissions : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/lakeformation_permissions aws_lakeformation_permissions} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLakeformationPermissions(Constructs.Construct scope, string id, aws.Lakeformation.IDataAwsLakeformationPermissionsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLakeformationPermissions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLakeformationPermissions(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDatabase\"}}]")]
        public virtual void PutDatabase(aws.Lakeformation.IDataAwsLakeformationPermissionsDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.IDataAwsLakeformationPermissionsDatabase)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDataLocation\"}}]")]
        public virtual void PutDataLocation(aws.Lakeformation.IDataAwsLakeformationPermissionsDataLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.IDataAwsLakeformationPermissionsDataLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTable\"}}]")]
        public virtual void PutTable(aws.Lakeformation.IDataAwsLakeformationPermissionsTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.IDataAwsLakeformationPermissionsTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTableWithColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTableWithColumns\"}}]")]
        public virtual void PutTableWithColumns(aws.Lakeformation.IDataAwsLakeformationPermissionsTableWithColumns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.IDataAwsLakeformationPermissionsTableWithColumns)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCatalogResource")]
        public virtual void ResetCatalogResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataLocation")]
        public virtual void ResetDataLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTable")]
        public virtual void ResetTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableWithColumns")]
        public virtual void ResetTableWithColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Lakeformation.DataAwsLakeformationPermissions))!;

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDatabaseOutputReference\"}")]
        public virtual aws.Lakeformation.DataAwsLakeformationPermissionsDatabaseOutputReference Database
        {
            get => GetInstanceProperty<aws.Lakeformation.DataAwsLakeformationPermissionsDatabaseOutputReference>()!;
        }

        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDataLocationOutputReference\"}")]
        public virtual aws.Lakeformation.DataAwsLakeformationPermissionsDataLocationOutputReference DataLocation
        {
            get => GetInstanceProperty<aws.Lakeformation.DataAwsLakeformationPermissionsDataLocationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Permissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PermissionsWithGrantOption
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTableOutputReference\"}")]
        public virtual aws.Lakeformation.DataAwsLakeformationPermissionsTableOutputReference Table
        {
            get => GetInstanceProperty<aws.Lakeformation.DataAwsLakeformationPermissionsTableOutputReference>()!;
        }

        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTableWithColumnsOutputReference\"}")]
        public virtual aws.Lakeformation.DataAwsLakeformationPermissionsTableWithColumnsOutputReference TableWithColumns
        {
            get => GetInstanceProperty<aws.Lakeformation.DataAwsLakeformationPermissionsTableWithColumnsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogResourceInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CatalogResourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDatabase\"}", isOptional: true)]
        public virtual aws.Lakeformation.IDataAwsLakeformationPermissionsDatabase? DatabaseInput
        {
            get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataLocationInput", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsDataLocation\"}", isOptional: true)]
        public virtual aws.Lakeformation.IDataAwsLakeformationPermissionsDataLocation? DataLocationInput
        {
            get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsDataLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableInput", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTable\"}", isOptional: true)]
        public virtual aws.Lakeformation.IDataAwsLakeformationPermissionsTable? TableInput
        {
            get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumnsInput", typeJson: "{\"fqn\":\"aws.lakeformation.DataAwsLakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        public virtual aws.Lakeformation.IDataAwsLakeformationPermissionsTableWithColumns? TableWithColumnsInput
        {
            get => GetInstanceProperty<aws.Lakeformation.IDataAwsLakeformationPermissionsTableWithColumns?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CatalogResource
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Principal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
