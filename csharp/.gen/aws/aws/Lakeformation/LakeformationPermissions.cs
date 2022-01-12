using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions aws_lakeformation_permissions}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lakeformation.LakeformationPermissions), fullyQualifiedName: "aws.lakeformation.LakeformationPermissions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lakeformation.LakeformationPermissionsConfig\"}}]")]
    public class LakeformationPermissions : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_permissions aws_lakeformation_permissions} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LakeformationPermissions(Constructs.Construct scope, string id, aws.Lakeformation.ILakeformationPermissionsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationPermissions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationPermissions(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDatabase\"}}]")]
        public virtual void PutDatabase(aws.Lakeformation.ILakeformationPermissionsDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.ILakeformationPermissionsDatabase)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDataLocation\"}}]")]
        public virtual void PutDataLocation(aws.Lakeformation.ILakeformationPermissionsDataLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.ILakeformationPermissionsDataLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTable\"}}]")]
        public virtual void PutTable(aws.Lakeformation.ILakeformationPermissionsTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.ILakeformationPermissionsTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTableWithColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTableWithColumns\"}}]")]
        public virtual void PutTableWithColumns(aws.Lakeformation.ILakeformationPermissionsTableWithColumns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lakeformation.ILakeformationPermissionsTableWithColumns)}, new object[]{@value});
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

        [JsiiMethod(name: "resetPermissionsWithGrantOption")]
        public virtual void ResetPermissionsWithGrantOption()
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
        = GetStaticProperty<string>(typeof(aws.Lakeformation.LakeformationPermissions))!;

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDatabaseOutputReference\"}")]
        public virtual aws.Lakeformation.LakeformationPermissionsDatabaseOutputReference Database
        {
            get => GetInstanceProperty<aws.Lakeformation.LakeformationPermissionsDatabaseOutputReference>()!;
        }

        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDataLocationOutputReference\"}")]
        public virtual aws.Lakeformation.LakeformationPermissionsDataLocationOutputReference DataLocation
        {
            get => GetInstanceProperty<aws.Lakeformation.LakeformationPermissionsDataLocationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTableOutputReference\"}")]
        public virtual aws.Lakeformation.LakeformationPermissionsTableOutputReference Table
        {
            get => GetInstanceProperty<aws.Lakeformation.LakeformationPermissionsTableOutputReference>()!;
        }

        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTableWithColumnsOutputReference\"}")]
        public virtual aws.Lakeformation.LakeformationPermissionsTableWithColumnsOutputReference TableWithColumns
        {
            get => GetInstanceProperty<aws.Lakeformation.LakeformationPermissionsTableWithColumnsOutputReference>()!;
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
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDatabase\"}", isOptional: true)]
        public virtual aws.Lakeformation.ILakeformationPermissionsDatabase? DatabaseInput
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataLocationInput", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsDataLocation\"}", isOptional: true)]
        public virtual aws.Lakeformation.ILakeformationPermissionsDataLocation? DataLocationInput
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsDataLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PermissionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsWithGrantOptionInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PermissionsWithGrantOptionInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableInput", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTable\"}", isOptional: true)]
        public virtual aws.Lakeformation.ILakeformationPermissionsTable? TableInput
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumnsInput", typeJson: "{\"fqn\":\"aws.lakeformation.LakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        public virtual aws.Lakeformation.ILakeformationPermissionsTableWithColumns? TableWithColumnsInput
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationPermissionsTableWithColumns?>();
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

        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Permissions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PermissionsWithGrantOption
        {
            get => GetInstanceProperty<string[]>()!;
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
