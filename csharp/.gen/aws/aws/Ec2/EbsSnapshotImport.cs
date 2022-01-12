using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ebs_snapshot_import aws_ebs_snapshot_import}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.EbsSnapshotImport), fullyQualifiedName: "aws.ec2.EbsSnapshotImport", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2.EbsSnapshotImportConfig\"}}]")]
    public class EbsSnapshotImport : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ebs_snapshot_import aws_ebs_snapshot_import} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EbsSnapshotImport(Constructs.Construct scope, string id, aws.Ec2.IEbsSnapshotImportConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EbsSnapshotImport(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EbsSnapshotImport(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.EbsSnapshotImportClientData\"}}]")]
        public virtual void PutClientData(aws.Ec2.IEbsSnapshotImportClientData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEbsSnapshotImportClientData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiskContainer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.EbsSnapshotImportDiskContainer\"}}]")]
        public virtual void PutDiskContainer(aws.Ec2.IEbsSnapshotImportDiskContainer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEbsSnapshotImportDiskContainer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.EbsSnapshotImportTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ec2.IEbsSnapshotImportTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEbsSnapshotImportTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientData")]
        public virtual void ResetClientData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncrypted")]
        public virtual void ResetEncrypted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleName")]
        public virtual void ResetRoleName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.EbsSnapshotImport))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientData", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportClientDataOutputReference\"}")]
        public virtual aws.Ec2.EbsSnapshotImportClientDataOutputReference ClientData
        {
            get => GetInstanceProperty<aws.Ec2.EbsSnapshotImportClientDataOutputReference>()!;
        }

        [JsiiProperty(name: "dataEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataEncryptionKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "diskContainer", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportDiskContainerOutputReference\"}")]
        public virtual aws.Ec2.EbsSnapshotImportDiskContainerOutputReference DiskContainer
        {
            get => GetInstanceProperty<aws.Ec2.EbsSnapshotImportDiskContainerOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportTimeoutsOutputReference\"}")]
        public virtual aws.Ec2.EbsSnapshotImportTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ec2.EbsSnapshotImportTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientDataInput", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportClientData\"}", isOptional: true)]
        public virtual aws.Ec2.IEbsSnapshotImportClientData? ClientDataInput
        {
            get => GetInstanceProperty<aws.Ec2.IEbsSnapshotImportClientData?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskContainerInput", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportDiskContainer\"}", isOptional: true)]
        public virtual aws.Ec2.IEbsSnapshotImportDiskContainer? DiskContainerInput
        {
            get => GetInstanceProperty<aws.Ec2.IEbsSnapshotImportDiskContainer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportTimeouts\"}", isOptional: true)]
        public virtual aws.Ec2.IEbsSnapshotImportTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ec2.IEbsSnapshotImportTimeouts?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Encrypted
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
