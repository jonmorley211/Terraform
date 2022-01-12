using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine aws_fsx_ontap_storage_virtual_machine}.</summary>
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOntapStorageVirtualMachine), fullyQualifiedName: "aws.fsx.FsxOntapStorageVirtualMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineConfig\"}}]")]
    public class FsxOntapStorageVirtualMachine : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine aws_fsx_ontap_storage_virtual_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FsxOntapStorageVirtualMachine(Constructs.Construct scope, string id, aws.Fsx.IFsxOntapStorageVirtualMachineConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapStorageVirtualMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapStorageVirtualMachine(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "endpoints", returnsJson: "{\"type\":{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineEndpoints\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Fsx.FsxOntapStorageVirtualMachineEndpoints Endpoints(string index)
        {
            return InvokeInstanceMethod<aws.Fsx.FsxOntapStorageVirtualMachineEndpoints>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "putActiveDirectoryConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration\"}}]")]
        public virtual void PutActiveDirectoryConfiguration(aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Fsx.IFsxOntapStorageVirtualMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOntapStorageVirtualMachineTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectoryConfiguration")]
        public virtual void ResetActiveDirectoryConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootVolumeSecurityStyle")]
        public virtual void ResetRootVolumeSecurityStyle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSvmAdminPassword")]
        public virtual void ResetSvmAdminPassword()
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
        = GetStaticProperty<string>(typeof(aws.Fsx.FsxOntapStorageVirtualMachine))!;

        [JsiiProperty(name: "activeDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference\"}")]
        public virtual aws.Fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference ActiveDirectoryConfiguration
        {
            get => GetInstanceProperty<aws.Fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subtype", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subtype
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineTimeoutsOutputReference\"}")]
        public virtual aws.Fsx.FsxOntapStorageVirtualMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Fsx.FsxOntapStorageVirtualMachineTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryConfigurationInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration? ActiveDirectoryConfigurationInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeSecurityStyleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootVolumeSecurityStyleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "svmAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SvmAdminPasswordInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineTimeouts\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOntapStorageVirtualMachineTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOntapStorageVirtualMachineTimeouts?>();
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootVolumeSecurityStyle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootVolumeSecurityStyle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "svmAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SvmAdminPassword
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
