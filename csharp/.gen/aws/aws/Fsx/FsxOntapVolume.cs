using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_volume aws_fsx_ontap_volume}.</summary>
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOntapVolume), fullyQualifiedName: "aws.fsx.FsxOntapVolume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.fsx.FsxOntapVolumeConfig\"}}]")]
    public class FsxOntapVolume : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_volume aws_fsx_ontap_volume} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FsxOntapVolume(Constructs.Construct scope, string id, aws.Fsx.IFsxOntapVolumeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapVolume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapVolume(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTieringPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOntapVolumeTieringPolicy\"}}]")]
        public virtual void PutTieringPolicy(aws.Fsx.IFsxOntapVolumeTieringPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOntapVolumeTieringPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOntapVolumeTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Fsx.IFsxOntapVolumeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOntapVolumeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSecurityStyle")]
        public virtual void ResetSecurityStyle()
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

        [JsiiMethod(name: "resetTieringPolicy")]
        public virtual void ResetTieringPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeType")]
        public virtual void ResetVolumeType()
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
        = GetStaticProperty<string>(typeof(aws.Fsx.FsxOntapVolume))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flexcacheEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlexcacheEndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ontapVolumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OntapVolumeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tieringPolicy", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapVolumeTieringPolicyOutputReference\"}")]
        public virtual aws.Fsx.FsxOntapVolumeTieringPolicyOutputReference TieringPolicy
        {
            get => GetInstanceProperty<aws.Fsx.FsxOntapVolumeTieringPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapVolumeTimeoutsOutputReference\"}")]
        public virtual aws.Fsx.FsxOntapVolumeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Fsx.FsxOntapVolumeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "junctionPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JunctionPathInput
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
        [JsiiProperty(name: "securityStyleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityStyleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInMegabytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeInMegabytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageEfficiencyEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StorageEfficiencyEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageVirtualMachineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageVirtualMachineIdInput
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
        [JsiiProperty(name: "tieringPolicyInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapVolumeTieringPolicy\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOntapVolumeTieringPolicy? TieringPolicyInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOntapVolumeTieringPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapVolumeTimeouts\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOntapVolumeTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOntapVolumeTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "junctionPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JunctionPath
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

        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStyle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeInMegabytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeInMegabytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageEfficiencyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StorageEfficiencyEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageVirtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageVirtualMachineId
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

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
