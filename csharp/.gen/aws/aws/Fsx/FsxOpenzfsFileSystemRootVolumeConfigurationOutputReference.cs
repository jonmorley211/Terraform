using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOpenzfsFileSystemRootVolumeConfigurationOutputReference), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FsxOpenzfsFileSystemRootVolumeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public FsxOpenzfsFileSystemRootVolumeConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsFileSystemRootVolumeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsFileSystemRootVolumeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNfsExports", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports\"}}]")]
        public virtual void PutNfsExports(aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports)}, new object[]{@value});
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

        [JsiiMethod(name: "resetReadOnly")]
        public virtual void ResetReadOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserAndGroupQuotas")]
        public virtual void ResetUserAndGroupQuotas()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "nfsExports", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference\"}")]
        public virtual aws.Fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference NfsExports
        {
            get => GetInstanceProperty<aws.Fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference>()!;
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
        [JsiiProperty(name: "nfsExportsInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports? NfsExportsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReadOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAndGroupQuotasInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[]? UserAndGroupQuotasInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[]?>();
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

        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReadOnly
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userAndGroupQuotas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas\"},\"kind\":\"array\"}}")]
        public virtual aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[] UserAndGroupQuotas
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
