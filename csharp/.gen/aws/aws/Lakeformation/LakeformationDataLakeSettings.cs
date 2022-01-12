using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings aws_lakeformation_data_lake_settings}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lakeformation.LakeformationDataLakeSettings), fullyQualifiedName: "aws.lakeformation.LakeformationDataLakeSettings", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsConfig\"}}]")]
    public class LakeformationDataLakeSettings : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings aws_lakeformation_data_lake_settings} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LakeformationDataLakeSettings(Constructs.Construct scope, string id, aws.Lakeformation.ILakeformationDataLakeSettingsConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationDataLakeSettings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationDataLakeSettings(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdmins")]
        public virtual void ResetAdmins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateDatabaseDefaultPermissions")]
        public virtual void ResetCreateDatabaseDefaultPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateTableDefaultPermissions")]
        public virtual void ResetCreateTableDefaultPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustedResourceOwners")]
        public virtual void ResetTrustedResourceOwners()
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
        = GetStaticProperty<string>(typeof(aws.Lakeformation.LakeformationDataLakeSettings))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AdminsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createDatabaseDefaultPermissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateDatabaseDefaultPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lakeformation.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[]? CreateDatabaseDefaultPermissionsInput
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createTableDefaultPermissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateTableDefaultPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions[]? CreateTableDefaultPermissionsInput
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustedResourceOwnersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TrustedResourceOwnersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "admins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Admins
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createDatabaseDefaultPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateDatabaseDefaultPermissions\"},\"kind\":\"array\"}}")]
        public virtual aws.Lakeformation.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[] CreateDatabaseDefaultPermissions
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createTableDefaultPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformation.LakeformationDataLakeSettingsCreateTableDefaultPermissions\"},\"kind\":\"array\"}}")]
        public virtual aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions[] CreateTableDefaultPermissions
        {
            get => GetInstanceProperty<aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustedResourceOwners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrustedResourceOwners
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
