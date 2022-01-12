using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume aws_fsx_openzfs_volume}.</summary>
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOpenzfsVolume), fullyQualifiedName: "aws.fsx.FsxOpenzfsVolume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeConfig\"}}]")]
    public class FsxOpenzfsVolume : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume aws_fsx_openzfs_volume} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FsxOpenzfsVolume(Constructs.Construct scope, string id, aws.Fsx.IFsxOpenzfsVolumeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsVolume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsVolume(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNfsExports", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExports\"}}]")]
        public virtual void PutNfsExports(aws.Fsx.IFsxOpenzfsVolumeNfsExports @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOpenzfsVolumeNfsExports)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOriginSnapshot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeOriginSnapshot\"}}]")]
        public virtual void PutOriginSnapshot(aws.Fsx.IFsxOpenzfsVolumeOriginSnapshot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOpenzfsVolumeOriginSnapshot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Fsx.IFsxOpenzfsVolumeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOpenzfsVolumeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCopyTagsToSnapshots")]
        public virtual void ResetCopyTagsToSnapshots()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataCompressionType")]
        public virtual void ResetDataCompressionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNfsExports")]
        public virtual void ResetNfsExports()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginSnapshot")]
        public virtual void ResetOriginSnapshot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadOnly")]
        public virtual void ResetReadOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageCapacityQuotaGib")]
        public virtual void ResetStorageCapacityQuotaGib()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageCapacityReservationGib")]
        public virtual void ResetStorageCapacityReservationGib()
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

        [JsiiMethod(name: "resetUserAndGroupQuotas")]
        public virtual void ResetUserAndGroupQuotas()
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
        = GetStaticProperty<string>(typeof(aws.Fsx.FsxOpenzfsVolume))!;

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

        [JsiiProperty(name: "nfsExports", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExportsOutputReference\"}")]
        public virtual aws.Fsx.FsxOpenzfsVolumeNfsExportsOutputReference NfsExports
        {
            get => GetInstanceProperty<aws.Fsx.FsxOpenzfsVolumeNfsExportsOutputReference>()!;
        }

        [JsiiProperty(name: "originSnapshot", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeOriginSnapshotOutputReference\"}")]
        public virtual aws.Fsx.FsxOpenzfsVolumeOriginSnapshotOutputReference OriginSnapshot
        {
            get => GetInstanceProperty<aws.Fsx.FsxOpenzfsVolumeOriginSnapshotOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeTimeoutsOutputReference\"}")]
        public virtual aws.Fsx.FsxOpenzfsVolumeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Fsx.FsxOpenzfsVolumeTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToSnapshotsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CopyTagsToSnapshotsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCompressionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataCompressionTypeInput
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
        [JsiiProperty(name: "nfsExportsInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExports\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsVolumeNfsExports? NfsExportsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeNfsExports?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originSnapshotInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeOriginSnapshot\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsVolumeOriginSnapshot? OriginSnapshotInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeOriginSnapshot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentVolumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentVolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReadOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageCapacityQuotaGibInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageCapacityQuotaGibInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageCapacityReservationGibInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageCapacityReservationGibInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeTimeouts\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsVolumeTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAndGroupQuotasInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeUserAndGroupQuotas\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsVolumeUserAndGroupQuotas[]? UserAndGroupQuotasInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeUserAndGroupQuotas[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "copyTagsToSnapshots", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CopyTagsToSnapshots
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCompressionType
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

        [JsiiProperty(name: "parentVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentVolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReadOnly
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageCapacityQuotaGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCapacityQuotaGib
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageCapacityReservationGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCapacityReservationGib
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "userAndGroupQuotas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeUserAndGroupQuotas\"},\"kind\":\"array\"}}")]
        public virtual aws.Fsx.IFsxOpenzfsVolumeUserAndGroupQuotas[] UserAndGroupQuotas
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeUserAndGroupQuotas[]>()!;
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
